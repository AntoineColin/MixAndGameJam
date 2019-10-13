using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    List<GameObject> ennemies = new List<GameObject>();

    void Start()
    {
        foreach(GameObject go in GameObject.FindGameObjectsWithTag("Ennemy"))
        {
            ennemies.Add(go);
        }

        GameObject.Find("Thief").GetComponent<Movement>().onDeath.AddListener(Reset);
    }

    private void Reset()
    {
        foreach(GameObject go in ennemies)
        {
            if (!go.activeSelf) go.SetActive(true);
        }
    }

    void Update()
    {
        if (Input.GetButtonDown("Quit"))
        {
            Application.Quit();
        }

        if (Input.GetButtonDown("Restart"))
        {
            GameObject.Find("Thief").GetComponent<Movement>().Die();
        }

        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            SceneManager.LoadScene("Level");
        }
    }
}
