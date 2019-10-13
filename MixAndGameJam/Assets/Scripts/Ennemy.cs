using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Ennemy : MonoBehaviour
{
    bool killable = false;
    
    public GameObject loot;
    static GameObject textUI;

    void Start()
    {
        if (textUI == null)
        {
            textUI = GameObject.Find("Assassinate");
            textUI.SetActive(false);
        }
       
       
        
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
            textUI.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            killable = false;
            textUI.SetActive(false);
        }
    }
}
