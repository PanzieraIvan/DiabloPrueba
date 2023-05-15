using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BruteStroke : MonoBehaviour
{
<<<<<<< Updated upstream
    public int m_playerHealth = 100;
    
    public bool m_invincible = false;
    public float m_currentInvincible = 1f;
    public float m_currentBrakeSpeed = 1f;


=======
    public float m_playerHealth = 100f;
    public bool m_invincible = false;
    public float m_currentInvincible = 1f;
    public float m_currentBrakeSpeed = 1f;
    public Animator m_animator;
    public GameObject m_GameObject;

>>>>>>> Stashed changes
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

<<<<<<< Updated upstream
    public void TakeDamageEnemy1(int p_damage = 15)
    {
        if (!m_invincible && m_playerHealth > 0)
        {
            m_playerHealth -= p_damage;
=======
    public void TakeDamageEnemy1(float p_damage = 15f)//metodo
    {
       

        if (!m_invincible && m_playerHealth > 0)
        {
            m_playerHealth -= p_damage;
            m_animator.SetTrigger("Punch");
            m_GameObject.SetActive(true);
>>>>>>> Stashed changes
            StartCoroutine(Invulnerability());
            StartCoroutine(BrakeSpeed());
            if (m_playerHealth == 0)
            {
                GameOver();
<<<<<<< Updated upstream
=======
                m_animator.SetTrigger("GameOver");
>>>>>>> Stashed changes
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

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            TakeDamageEnemy2();
        }
    }
    public void TakeDamageEnemy2(int p_damage = 5)
    {
        if (!m_invincible && m_playerHealth > 0)
        {
            m_playerHealth -= p_damage;
<<<<<<< Updated upstream
            StartCoroutine(Invulnerability());
            StartCoroutine(BrakeSpeed());
            if (m_playerHealth == 0)
            {
                GameOver();
            }
=======
            m_animator.SetTrigger("Punch");
            StartCoroutine(Invulnerability());
            StartCoroutine(BrakeSpeed());
>>>>>>> Stashed changes
        }

    }

    private void Update()
    {
<<<<<<< Updated upstream
        if (m_playerHealth == 0)
        {
            GameOver();
=======
        if(Input.GetKey(KeyCode.K))
        {
            m_animator.SetTrigger("Punch");

>>>>>>> Stashed changes
        }
    }

}

 
