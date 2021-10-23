using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CI.QuickSave;

public class Setup : MonoBehaviour
{

    public bool isSetup = false;
    // Start is called before the first frame update
    void Start()
    {
        try
        {
            var reader = QuickSaveReader.Create("isSetup");
        }
        catch
        {
            var nothing = QuickSaveWriter.Create("isSetup");
            var writer = QuickSaveWriter.Create("Points");
            writer
                .Write("Points", 0)
                .Commit();
            var writer2 = QuickSaveWriter.Create("user");
            //
            writer2
                .Write("current", 1)
                .Write("alpaca", 0)
                .Commit();
            var writer1 = QuickSaveWriter.Create("isSetup");
            writer1
                .Write("is", true)
                .Commit();
        }
        if (isSetup == true)
        {
            var writer = QuickSaveWriter.Create("Points");
            writer
                .Write("Points", 0)
                .Commit();
            var writer1 = QuickSaveWriter.Create("isSetup");
            writer1
                .Write("is", true)
                .Commit();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
