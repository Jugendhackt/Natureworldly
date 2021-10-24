using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using CI.QuickSave;

public class PunktAnzahl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var reader = QuickSaveReader.Create("Points");
        var points = reader.Read<int>("Points");
        Debug.Log(points);
        Debug.Log(this.GetComponent<Text>());
        this.GetComponent<Text>().text = points.ToString();
    }
}
