using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSceneManager : MonoBehaviour
{
  
    public void LoadLevelTutorial(string p_levelToLoadTutorial)
    {
        SceneManager.LoadScene(p_levelToLoadTutorial);
    }

    public void LoadLevelZero(string p_levelToLoadZero)
    {
        SceneManager.LoadScene(p_levelToLoadZero);
    }

    public void LoadLevelOne(string p_levelToLoadOne)
    {
        SceneManager.LoadScene(p_levelToLoadOne);
    }

    public void LoadLevelTwo(string p_levelToLoadTwo)
    {
        SceneManager.LoadScene(p_levelToLoadTwo);
    }
    public void LoadLevelThree(string p_levelToLoadThree)
    {
        SceneManager.LoadScene(p_levelToLoadThree);
    }

    public void LoadGameOptions(string p_loadGameOptions)
    {
        SceneManager.LoadScene(p_loadGameOptions);
    }
}
