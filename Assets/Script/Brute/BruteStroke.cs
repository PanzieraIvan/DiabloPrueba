using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BruteStroke : MonoBehaviour
{
    [SerializeField] private float m_playerHealth = 100f;


    public void TakeDamageEnemy1(float p_damage = 15f)
    {
        m_playerHealth -= p_damage;

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
    public void TakeDamageEnemy2(float p_damage = 5f)
    {
        m_playerHealth -= p_damage;

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

 
