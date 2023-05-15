using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BruteMovement : MonoBehaviour
{
    public float speedBrute = 10f;
    [SerializeField] private float rotationSpeedBrute = 30f;
    public Animator m_bruteAnimation;
    private bool m_atackPlayer;
    private float attackTime = 2f;
    private void Start()
    {
        m_atackPlayer = false;
        
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
    IEnumerator Attak()
    {
        m_atackPlayer = true;
        m_bruteAnimation.SetTrigger("Atackk");
        yield return new WaitForSeconds(attackTime);
        m_atackPlayer = false;

    }
    void Update()
    {
        if (!m_atackPlayer)
        {
            MovePlayer();
        }
        if (Input.GetButtonDown("Fire1"))
        {
            StartCoroutine(Attak());
        }
    }
    

}
