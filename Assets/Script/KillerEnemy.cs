using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillerEnemy : MonoBehaviour
{
    public int namberScene;
    

    private void OnTriggerEnter(Collider other)
    {
        if (!GameObject.FindGameObjectWithTag("Enemy"))
        {
            if (other.CompareTag("Player"))
            {
                SceneManager.LoadScene(namberScene);

            }
        }
    }
   
}
