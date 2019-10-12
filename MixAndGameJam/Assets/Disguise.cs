using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Disguise : MonoBehaviour
{

    bool takeable = false;
    UnityEvent onTakeable = new UnityEvent(), onNonTakeable = new UnityEvent();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (takeable && Input.GetButtonDown("Action"))
        {
            gameObject.SetActive(false);
            GameObject.Find("Thief").SendMessage("SetDisguise","red");
        
            
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            takeable = true;
            if (onTakeable != null) onTakeable.Invoke();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            takeable = false;
            if (onNonTakeable != null) onNonTakeable.Invoke();
        }
    }
}