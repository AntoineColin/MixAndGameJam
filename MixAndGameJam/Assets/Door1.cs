using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door1 : MonoBehaviour
{
    public DisguiseZone key;
    public Color32 padlock;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SpriteRenderer keySprite = key.GetComponent<SpriteRenderer>();
        if (keySprite.color == padlock)
        {
            gameObject.SetActive(false);
        }
    }
}
