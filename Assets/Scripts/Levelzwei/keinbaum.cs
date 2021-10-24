using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CI.QuickSave;

public class keinbaum : MonoBehaviour
{
    public GameObject Player;
    public Sprite baumtextur;
    public GameObject partikel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var dis = Vector3.Distance(Player.transform.position, this.transform.position);
        if(dis < 0.5f && this.GetComponent<SpriteRenderer>().sprite != baumtextur)
        {
            
            StartCoroutine(waiter());
        }
    }
    IEnumerator waiter()
    {
        partikel.SetActive(true);

        //Wait for 4 seconds
        yield return new WaitForSeconds(1);
        partikel.SetActive(false);
        this.GetComponent<SpriteRenderer>().sprite = baumtextur;
        var points = QuickSaveReader.Create("Points");
        var realpoints = points.Read<int>("Points");
        var writer = QuickSaveWriter.Create("Points");
        writer
            .Write("Points", realpoints + 10)
            .Commit();
    }
}
