using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tueteTrigger : MonoBehaviour
{
    public GameObject ui;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ui.active && Input.GetMouseButtonDown(1))
        {
            ui.SetActive(false);
        }
    }

    void OnMouseDown()
    {
        if (!ui.active)
        {
            ui.SetActive(true);
        }
    }
}
