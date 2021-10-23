using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mull : MonoBehaviour
{
    public Sprite texture1;
    public Sprite texture2;
    public Sprite texture3;
    public SpriteRenderer spriterenderer;
    public GameObject derMull; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Hi");
        if (Random.Range(0, 1000) == 1)
        {
            Debug.Log("hey");
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
    }
}
