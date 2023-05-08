using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExperienceAdder : MonoBehaviour
{
    [SerializeField] private int m_experienceToAdd;


   
    private void Update()
    {
        //Sumar Experiencia en el personaje cuando mate un enemigo
        if (Input.GetKeyDown(KeyCode.J))
        {
            GameManager.Instance.AddExperience(m_experienceToAdd);
        }
    }
}
