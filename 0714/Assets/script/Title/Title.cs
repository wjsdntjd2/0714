using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour
{
    public GameObject Stop;

    public void SceneLoad(int val)
    {
        SceneManager.LoadScene(val);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Stop.SetActive(true);
            Time.timeScale = 0;
        }
    }
    public void asdf()
    {
        Stop.SetActive(false);
        Time.timeScale = 1;

    }
}
