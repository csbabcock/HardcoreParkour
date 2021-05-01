using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{

    void Start()
    {
        Time.timeScale = 0;
        Cursor.visible = true;
    }
    public void StartOver()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1;
    }
}
