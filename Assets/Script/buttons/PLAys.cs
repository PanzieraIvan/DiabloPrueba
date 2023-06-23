using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLAys : MonoBehaviour
{
    public Animator play;
    // Start is called before the first frame update
    void Start()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            play.SetTrigger("PLay");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
