using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Disguise : MonoBehaviour
{

    bool takeable = false;

    void Start()
    {
        
    }

    void Update()
    {
        if (takeable && Input.GetButtonDown("Action"))
        {
            gameObject.SetActive(false);
            GameObject.Find("Thief").GetComponent<Movement>().color = GetComponent<SpriteRenderer>().color;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            takeable = true;
            DisguiseZone.disguiseText.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            takeable = false;
            DisguiseZone.disguiseText.SetActive(false);
        }
    }
}