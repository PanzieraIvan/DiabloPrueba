using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonsMenu : MonoBehaviour
{
    public AudioSource Sound;
    public AudioClip SoundMenu;
    
    public void  SoundButton()

    {
        Sound.clip = SoundMenu;
        Sound.enabled = false;
        Sound.enabled = true;

    }
    
}
