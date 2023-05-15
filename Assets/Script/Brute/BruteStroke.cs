using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BruteStroke : MonoBehaviour
{
<<<<<<< Updated upstream
    [SerializeField] private float m_playerHealth = 100f;


    public void TakeDamageEnemy1(float p_damage = 15f)
=======
    public float m_playerHealth = 100f;
    public bool m_invincible = false;
    public float m_currentInvincible = 1f;
    public float m_currentBrakeSpeed = 1f;
    public Animator m_animator;
    public GameObject m_GameObject;

    IEnumerator Invulnerability()
>>>>>>> Stashed changes
    {
        m_playerHealth -= p_damage;

<<<<<<< Updated upstream
        if (m_playerHealth < 0)
        {
            m_playerHealth = 0;
=======
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

    public void TakeDamageEnemy1(float p_damage = 15f)//metodo
    {
       

        if (!m_invincible && m_playerHealth > 0)
        {
            m_playerHealth -= p_damage;
            m_animator.SetTrigger("Punch");
            m_GameObject.SetActive(true);
            StartCoroutine(Invulnerability());
            StartCoroutine(BrakeSpeed());
            if (m_playerHealth == 0)
            {
                GameOver();
                m_animator.SetTrigger("GameOver");
            }
>>>>>>> Stashed changes
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
<<<<<<< Updated upstream
            m_playerHealth = 0;
=======
            m_playerHealth -= p_damage;
            m_animator.SetTrigger("Punch");
            StartCoroutine(Invulnerability());
            StartCoroutine(BrakeSpeed());
>>>>>>> Stashed changes
        }

    }
    private void Update()
    {
<<<<<<< Updated upstream
        if (Input.GetMouseButtonDown(0))
        {
=======
        if(Input.GetKey(KeyCode.K))
        {
            m_animator.SetTrigger("Punch");
>>>>>>> Stashed changes

        }
    }
}

 
