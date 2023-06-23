using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonPlays : MonoBehaviour
{
    public void SceneGame()
    {
        SceneManager.LoadScene("ScreenTutorial");
    }

    public void Option(string nonbreNivel)
    {
        SceneManager.LoadScene(nonbreNivel);

    }
    public void salir()
    {
        Application.Quit();
        Debug.Log("exit....");
    }

}
