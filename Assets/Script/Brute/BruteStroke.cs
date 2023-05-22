using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BruteStroke : MonoBehaviour
{
    public float m_playerHealth = 1f;
   
    public Slider m_playerSlider;
    
    public bool m_invincible = false;
    public float m_currentInvincible = 1f;
    public float m_currentBrakeSpeed = 1f;
   

    IEnumerator Invulnerability()
    {
        m_invincible = true;
        yield return new WaitForSeconds(m_currentInvincible);
        m_invincible = false;
    }

    IEnumerator BrakeSpeed()
    {
        var currentSpeed = GetComponent<BruteMovement>().speedBrute;
        GetComponent<BruteMovement>().speedBrute = 3f;
        yield return new WaitForSeconds(m_currentBrakeSpeed);
        GetComponent<BruteMovement>().speedBrute = currentSpeed;

    }

    public void GameOver()
    {
        Debug.Log("Game Over !!");
        Time.timeScale = 0;
    }

   
    public void TakeDamageEnemy1(float p_damage = 1 * 0.2f)
    {
        
        if (!m_invincible && m_playerHealth > 0)
        {
            
            m_playerHealth -= p_damage;
            StartCoroutine(Invulnerability());
            StartCoroutine(BrakeSpeed());
            if (m_playerHealth <= 0)
            {
                GameOver();
            }
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

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("PPPPP");
            TakeDamageEnemy2();
            
        }
    }
    public void TakeDamageEnemy2(float p_damage = 1 * 0.2f)
    {
        if (!m_invincible && m_playerHealth > 0)
        {
            
            m_playerHealth -= p_damage;
            StartCoroutine(Invulnerability());
            StartCoroutine(BrakeSpeed());
            if (m_playerHealth <= 0)
            {
                GameOver();
            }
        }

    }
    private void Update()
    {
        if (m_playerHealth <= 0)
        {
            GameOver();
        }
        m_playerSlider.value = m_playerHealth;
    }




}

 
