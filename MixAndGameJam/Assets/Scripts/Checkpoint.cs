using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Checkpoint : MonoBehaviour
{

    public UnityEvent onSave = new UnityEvent();

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            collision.gameObject.GetComponent<Movement>().SavePosition(transform.position.x);
            if (onSave != null) onSave.Invoke();
        }
    }
}
