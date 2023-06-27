using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private Button m_playGame;
    [SerializeField] private LevelSceneManager m_loadSceneManager;

    public int namberScene;
    

    public void PlayGame()
    {
        SceneManager.LoadScene(namberScene);
    }
    
    public void ExitGame()
    {
        Application.Quit();
    }
    public void Credits()
    {
        
        
    }
}
