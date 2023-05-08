using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExperienceCharacter : MonoBehaviour
{
    private int m_currentExperience;

    public int GetCurrentExperience() => m_currentExperience;
    //Experiencia del player
  public void Add(int p_experience)
    {
        m_currentExperience += p_experience;
        Debug.Log($"Current experience{m_currentExperience}");
    }
}
