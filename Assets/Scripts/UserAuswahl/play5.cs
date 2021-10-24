using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using CI.QuickSave;
using UnityEngine.SceneManagement;

public class play5 : MonoBehaviour
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
        if (reader.Read<int>("alpaca5") == 1)
        {
            this.GetComponent<Image>().sprite = texture2;
        }
    }

    public void Click()
    {
        if (this.GetComponent<Image>().sprite != texture2)
        {
            var points = QuickSaveReader.Create("Points");
            var realpoints = points.Read<int>("Points");
            if (realpoints > 100)
            {
                var writer = QuickSaveWriter.Create("Points");
                writer
                    .Write("Points", realpoints - 100)
                    .Commit();
                var newwriter = QuickSaveWriter.Create("user");
                newwriter
                    .Write("alpaca5", 1)
                    .Write("current", 3)
                    .Commit();
            }
        }
        else
        {
            var newwriter = QuickSaveWriter.Create("user");
            newwriter
                .Write("current", 3)
                .Commit();
            SceneManager.LoadScene("TitleScreen");
        }
    }
}
