using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private ExperienceCharacter m_experienceCharacter;
    [SerializeField] private LevelSceneManager m_levelSceneManager;

    public static GameManager Instance;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;

            //Guardar para siguiente Scene
            DontDestroyOnLoad(gameObject);
        }
    }
    public void AddExperience(int p_experience)
    {
        //Esto lo podriamos usar cuando se termina un lvl que se transfiera a base.
        m_experienceCharacter.Add(p_experience);
        var l_currentExperience = m_experienceCharacter.GetCurrentExperience();
        if (l_currentExperience > 50)
        {
            TryLoadLevelTutoria("ScreenLevel0");
        }
    }

    public void TryLoadLevelTutoria(string p_levelToLoadTutorial)
    {
        m_levelSceneManager.LoadLevelTutorial(p_levelToLoadTutorial);
    }
}
