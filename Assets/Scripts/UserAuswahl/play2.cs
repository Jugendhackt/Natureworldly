using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CI.QuickSave;

public class play2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Click()
    {
        var writer = QuickSaveWriter.Create("user");
        writer
            .Write("current", 2)
            .Commit();
    }
}
