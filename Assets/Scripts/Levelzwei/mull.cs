using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CI.QuickSave;

public class mull : MonoBehaviour
{
    public Sprite texture1;
    public Sprite texture2;
    public Sprite texture3;
    public SpriteRenderer spriterenderer;
    public GameObject derMull;
    public GameObject player;
    public Zange zange;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!(derMull.active) && Random.Range(0, 3000) == 1)
        {
            int randomn = Random.Range(1, 4);
            if (randomn == 1)
            {
                spriterenderer.sprite = texture1;
            }
            else if (randomn == 2)
            {
                spriterenderer.sprite = texture2;
            }
            else if (randomn == 3)
            {
                spriterenderer.sprite = texture3;
            }
            else
            {
                spriterenderer.sprite = texture1;
            }
            derMull.SetActive(true);
        }


        var dis = Vector3.Distance(derMull.transform.position, player.transform.position);
        if(derMull.active && dis < 1.0f && zange.playerobtains)
        {
            var reader = QuickSaveReader.Create("Points");
            var points = reader.Read<int>("Points");
            var writer = QuickSaveWriter.Create("Points");
            writer.Write("Points", points + 1);
            writer.Commit();
            derMull.SetActive(false);
        }
    }
}
