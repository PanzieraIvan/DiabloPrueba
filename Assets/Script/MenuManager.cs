using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private Button m_playGame;
   public void PlayGame()
    {
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
