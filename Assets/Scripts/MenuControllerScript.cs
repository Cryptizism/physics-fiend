using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControllerScript : MonoBehaviour
{
    public void quitGame()
    {
        Application.Quit();
    }

    public void playLevel(int level)
    {
        SceneManager.LoadScene(level);
    }

    public void startGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
