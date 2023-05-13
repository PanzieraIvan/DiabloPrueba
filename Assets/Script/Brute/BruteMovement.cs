using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BruteMovement : MonoBehaviour
{
    [SerializeField] private float speedBrute = 10f;
    [SerializeField] private float rotationSpeedBrute = 30f;
    public Animator m_bruteAnimation;
    private bool m_atackPlayer;

    public void MovePlayer()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        var l_moventDir = new Vector3(moveHorizontal, 0, moveVertical);
        l_moventDir.Normalize();

        transform.position += l_moventDir * speedBrute * Time.deltaTime;
        if (l_moventDir != Vector3.zero) transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(l_moventDir), rotationSpeedBrute * Time.deltaTime);

        m_bruteAnimation.SetFloat("SpeedBrute", l_moventDir.magnitude * speedBrute);

        if (Input.GetMouseButtonDown(0))
        {
            m_atackPlayer = !m_atackPlayer;
            m_bruteAnimation.SetBool("Atack", m_atackPlayer);
        }
    }
    void Update()
    {
        MovePlayer();
    }
}
