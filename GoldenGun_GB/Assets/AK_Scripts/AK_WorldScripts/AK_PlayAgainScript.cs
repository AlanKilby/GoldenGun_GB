using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AK_PlayAgainScript : MonoBehaviour
{
    public Scene activeScene;

    private void Start()
    {
        activeScene = SceneManager.GetActiveScene();
        
    }

    private void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            SceneManager.LoadScene(activeScene.buildIndex);
        }

        if (Input.GetButtonDown("Shoot"))
        {
            SceneManager.LoadScene("MainMenu");
        }
    }


}
