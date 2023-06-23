using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPress : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource Sound;
    public AudioClip SoundPres;

    public void SoundButton()

    {
        Sound.clip = SoundPres;
        Sound.enabled = false;
        Sound.enabled = true;

    }
}
