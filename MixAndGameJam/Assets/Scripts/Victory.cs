using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Victory : MonoBehaviour
{
    public UnityEvent onWin = new UnityEvent();
    GameObject victoryText;

    private void Start()
    {
        victoryText = GameObject.Find("Victory");
        victoryText.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        StartCoroutine(Finish());
    }

    public IEnumerator Finish()
    {
        yield return new WaitForSeconds(0.3f);
        victoryText.SetActive(true);
    }
}
