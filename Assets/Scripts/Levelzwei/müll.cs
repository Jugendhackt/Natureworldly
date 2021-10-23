using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class müll : MonoBehaviour
{
    public Sprite texture1;
    public Sprite texture2;
    public Sprite texture3;
    public SpriteRenderer spriterenderer;
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
        if(Random.Range(0, 1000) == 1)
        {
            int randomn = Random.Range(1, 4);
            if (randomn == 1)
            {
                spriterenderer.sprite = texture1;
            }else if (randomn == 2)
            {
                spriterenderer.sprite = texture2;
            }else if (randomn == 3)
            {
                spriterenderer.sprite = texture3;
            }
            else
            {
                spriterenderer.sprite = texture1;
            }
            this.SetActive(true);
        }
    }
}
