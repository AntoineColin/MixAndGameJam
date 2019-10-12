using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerZone : MonoBehaviour
{

    public UnityEvent onTriggerEnter = new UnityEvent(), onTriggerStay = new UnityEvent(), onTriggerExit = new UnityEvent();


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            if (onTriggerEnter != null) onTriggerEnter.Invoke();
            collision.gameObject.SendMessage("Die");
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
