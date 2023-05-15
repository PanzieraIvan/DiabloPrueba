using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BruteStroke : MonoBehaviour
{
    [SerializeField] Enemy1 m_enemy1;
    [SerializeField] Enemy2 m_enemy2;

    [SerializeField] private float m_playerHealth = 100f;


    public void TakeDamageEnemy1()
    {
        m_playerHealth -= m_enemy1.damageEnemy1;

        if (m_playerHealth < 0)
        {
            m_playerHealth = 0;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("IceBall"))
        {
            TakeDamageEnemy1();
            Destroy(other);

        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            TakeDamageEnemy2();
        }
    }
    public void TakeDamageEnemy2()
    {
        m_playerHealth -= m_enemy2.damageEnemy2;

        if (m_playerHealth < 0)
        {
            m_playerHealth = 0;
        }

    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

        }
    }
}

 
