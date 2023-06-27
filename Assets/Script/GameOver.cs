using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public int namberScene;


    public void PlayGame()
    {
        SceneManager.LoadScene(namberScene);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
