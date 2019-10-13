using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Ennemy : MonoBehaviour
{
    bool killable = false;
    UnityEvent onKillable = new UnityEvent(), onNonKillable = new UnityEvent();
    public GameObject loot;

    void Start()
    {
        
    }

    void Update()
    {
        if( killable && Input.GetButtonDown("Action"))
        {
            gameObject.SetActive(false);
            if (loot != null)
            {
                Instantiate(loot, this.transform.position, this.transform.rotation);
            }
           
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            killable = true;
            if (onKillable != null) onKillable.Invoke();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            killable = false;
            if (onNonKillable != null) onNonKillable.Invoke();
        }
    }
}
