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
            Debug.Log("Reset !");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Quit"))
        {
            Application.Quit();
        }

        if (Input.GetButtonDown("Restart"))
        {
            SceneManager.LoadScene(0);
        }
    }
}
