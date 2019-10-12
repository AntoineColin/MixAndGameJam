using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerZone : MonoBehaviour
{
    SpriteRenderer sprite;
    public Color32 color;
    public UnityEvent onTriggerEnter = new UnityEvent(), onTriggerStay = new UnityEvent(), onTriggerExit = new UnityEvent();

    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        color = sprite.color;
        onTriggerStay.AddListener(Watch);
    }

    void Watch()
    {
        GameObject.Find("Thief").GetComponent<Movement>().Stealth(color);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            if (onTriggerEnter != null) onTriggerEnter.Invoke();
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (onTriggerStay != null) onTriggerStay.Invoke();
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (onTriggerExit != null) onTriggerExit.Invoke();
        }
    }
}
