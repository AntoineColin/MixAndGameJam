using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DisguiseZone : MonoBehaviour
{
    UnityEvent onDisguiseZone = new UnityEvent(), onNonDisguiseZone = new UnityEvent();
    bool activable = false;

    private void Update()
    {
        if(Input.GetButtonDown("Action") && activable)
        {
            SpriteRenderer characterRenderer = GameObject.Find("Thief").GetComponent<SpriteRenderer>();
            SpriteRenderer disguiseRenderer = gameObject.GetComponent<SpriteRenderer>();
            Debug.Log("character : " + characterRenderer.color + " et deguisement : " + disguiseRenderer.color);
            Color exchange = characterRenderer.color;
            characterRenderer.color = disguiseRenderer.color;
            disguiseRenderer.color = exchange;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            activable = true;
            if (onDisguiseZone != null) onDisguiseZone.Invoke();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            activable = false;
            if (onNonDisguiseZone != null) onNonDisguiseZone.Invoke();
        }
    }
}
