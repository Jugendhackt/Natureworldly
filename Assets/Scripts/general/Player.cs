using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CI.QuickSave;

public class Player : MonoBehaviour
{

    public Sprite texture1;
    public Sprite texture2;
    public Sprite texture3;
    // Start is called before the first frame update
    void Start()
    {
        var reader = QuickSaveReader.Create("user");
        var current = reader.Read<int>("current");
        if(current == 1)
        {
            this.GetComponent<SpriteRenderer>().sprite = texture1;
        }else if (current == 2)
        {
            this.GetComponent<SpriteRenderer>().sprite = texture2;
        }else if (current == 3)
        {
            this.GetComponent<SpriteRenderer>().sprite = texture3;
        }
        else
        {
            this.GetComponent<SpriteRenderer>().sprite = texture1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
