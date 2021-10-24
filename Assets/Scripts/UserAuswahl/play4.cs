using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using CI.QuickSave;
using UnityEngine.SceneManagement;

public class play4 : MonoBehaviour
{
    public Sprite texture2;
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
        if (this.GetComponent<Image>().sprite != texture2)
        {
            var points = QuickSaveReader.Create("Points");
            var realpoints = points.Read<int>("Points");
            if (realpoints > 200)
            {
                var writer = QuickSaveWriter.Create("Points");
                writer
                    .Write("Points", realpoints - 200)
                    .Commit();
                var newwriter = QuickSaveWriter.Create("user");
                newwriter
                    .Write("alpaca4", 1)
                    .Write("current", 4)
                    .Commit();
            }
        }
        else
        {
            var newwriter = QuickSaveWriter.Create("user");
            newwriter
                .Write("current", 4)
                .Commit();
            SceneManager.LoadScene("TitleScreen");
        }
    }
}
