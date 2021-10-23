using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zange : MonoBehaviour
{
    public bool playerobtains = false;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        Debug.Log(Vector3.Distance(player.transform.position, this.transform.position) < 0.5f);
        if(Vector3.Distance(player.transform.position, this.transform.position) < 0.5f)
        {
            this.playerobtains = true;
        }
        if (playerobtains)
        {
            this.transform.position = player.transform.position;
        }
    }
}
