using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CI.QuickSave;
using UnityEngine.UI;

public class play3 : MonoBehaviour
{
    public Sprite texture2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var reader = QuickSaveReader.Create("user");
        if(reader.Read<int>("alpaca3") == 1)
        {
            this.GetComponent<Image>().sprite = texture2;
        }
    }

    public void Click()
    {
        if(this.GetComponent<Image>().sprite == texture2)
        {
            var Points = QuickSaveReader.Create("Points");
            // HIER CODEN
        }
    }
}
