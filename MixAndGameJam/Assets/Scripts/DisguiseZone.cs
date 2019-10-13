using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DisguiseZone : MonoBehaviour
{
    bool activable = false;
    public static GameObject disguiseText;


    private void Start()
    {
        if (disguiseText == null)
        {
            disguiseText = GameObject.Find("Disguise");
            Debug.Log("coucou");
            disguiseText.SetActive(false);
        }
    }
    private void Update()
    {
        if(Input.GetButtonDown("Action") && activable)
        {
            Movement character = GameObject.Find("Thief").GetComponent<Movement>();
            SpriteRenderer disguiseRenderer = gameObject.GetComponent<SpriteRenderer>();
            Color exchange = character.color;
            character.color = disguiseRenderer.color;
            disguiseRenderer.color = exchange;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            activable = true;
            disguiseText.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            activable = false;
            disguiseText.SetActive(false);
        }
    }
}
