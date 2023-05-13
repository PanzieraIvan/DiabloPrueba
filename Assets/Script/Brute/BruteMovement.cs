using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BruteMovement : MonoBehaviour
{
    [SerializeField] private float speedBrute = 10f;
    [SerializeField] private float rotationSpeedBrute = 30f;
    public Animator m_bruteAnimation;
    private bool m_atackPlayer;
    private bool canMOve;
    private bool canAtack;


    private void Start()
    {
        m_atackPlayer = false;
        canAtack = false;
    }


    public void MovePlayer()
    {
      
        

            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");
            var l_moventDir = new Vector3(moveHorizontal, 0, moveVertical);
            l_moventDir.Normalize();

            transform.position += l_moventDir * speedBrute * Time.deltaTime;
            if (l_moventDir != Vector3.zero) transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(l_moventDir), rotationSpeedBrute * Time.deltaTime);

            m_bruteAnimation.SetFloat("SpeedBrute", moveHorizontal/*l_moventDir.magnitude * speedBrute*/);
            m_bruteAnimation.SetFloat("SpeedBrute1", moveVertical/*l_moventDir.magnitude * speedBrute*/);

         
    }


    public void Aatk()
    {
        
        if (Input.GetButtonDown("Fire1"))
        {
            
            m_bruteAnimation.SetTrigger("Atackk");

            //m_atackPlayer = !m_atackPlayer;
            //m_br
            //uteAnimation.SetBool("Atack", m_atackPlayer);
            Debug.Log("aaaaaa");
            speedBrute = 0f;
            
        }
       
    }


    void Update()
    { 
       
            MovePlayer();
        
        
            Aatk();
        

  

    }
    //public void Ataca()
    //{
    //    canMOve = false;
    //}
    //public void DejaDeAtacar()
    //{
    //    canMOve = true;
    //}

}
