using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public void LaunchGame()
    {
        Time.timeScale = 1; // evito que los personajes se frizen cuando arranco
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Application.Quit();
        SceneManager.LoadScene(0);
    }
}