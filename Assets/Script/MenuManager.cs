using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private Button m_playGame;
    [SerializeField] private LevelSceneManager m_loadSceneManager;
    public void PlayGame(string p_levelToLoadTutorial)
    {
        m_loadSceneManager.LoadLevelTutorial(p_levelToLoadTutorial);
        Debug.Log("Play Game");
    }
    public void ExitGame()
    {
        Debug.Log("Exit Game");
    }
    public void Credits()
    {
        Debug.Log("Credits .......");
    }
}
