using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door2 : MonoBehaviour
{
    public DisguiseZone key1;
    public DisguiseZone key2;
    public Color32 padlock1;
    public Color32 padlock2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SpriteRenderer keySprite1 = key1.GetComponent<SpriteRenderer>();
        SpriteRenderer keySprite2 = key2.GetComponent<SpriteRenderer>();
        if (keySprite1.color == padlock1 && keySprite2.color == padlock2)
        {
            gameObject.SetActive(false);
        }
    }
}
