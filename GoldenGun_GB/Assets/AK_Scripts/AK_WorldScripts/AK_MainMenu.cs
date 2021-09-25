using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AK_MainMenu : MonoBehaviour
{

    public string playScene;
    public string creditsScene;
    public string mainMenu;

    public void PlayGame()
    {
        SceneManager.LoadScene(playScene);
    }

    public void Credits()
    {
        SceneManager.LoadScene(creditsScene);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(mainMenu);
    }
}
