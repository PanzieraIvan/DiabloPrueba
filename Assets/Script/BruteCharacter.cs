using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BruteCharacter : PlayableCharacter
{
    public float currentHealth;
    private bool m_atackPlayer;
    private float attackTime = 2f;
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
        var currentSpeed = m_speed;
        m_speed = 3f;
        yield return new WaitForSeconds(m_currentBrakeSpeed);
        m_speed = currentSpeed;

    }
    IEnumerator Attak()
    {
        m_atackPlayer = true;
        m_animation.SetTrigger("Atackk");
        yield return new WaitForSeconds(attackTime);
        m_atackPlayer = false;

    }
    private void Awake()
    {
        currentHealth = m_maxHealth;
    }
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

        MoveCharacter(l_moventDir);
        if (l_moventDir != Vector3.zero) transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(l_moventDir), m_rotation * Time.deltaTime);

        m_animation.SetFloat("SpeedBrute", moveHorizontal/*l_moventDir.magnitude * speedBrute*/);
        m_animation.SetFloat("SpeedBrute1", moveVertical/*l_moventDir.magnitude * speedBrute*/);
    }
    
    public void GameOver()
    {
        Debug.Log("Game Over !!");
        Time.timeScale = 0;
    }

    public void TakeDamageEnemy1(float p_damage = 1 * 0.2f)
    {

        if (!m_invincible && currentHealth > 0)
        {

            currentHealth -= p_damage;
            StartCoroutine(Invulnerability());
            StartCoroutine(BrakeSpeed());
            if (currentHealth <= 0)
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
            
            TakeDamageEnemy2();

        }
    }
    public void TakeDamageEnemy2(float p_damage = 1 * 0.2f)
    {
        if (!m_invincible && currentHealth > 0)
        {

            currentHealth -= p_damage;
            StartCoroutine(Invulnerability());
            StartCoroutine(BrakeSpeed());
            if (currentHealth <= 0)
            {
                GameOver();
            }
        }

    }
    void Update()
    {
        m_slider.value = currentHealth;

        if (!m_atackPlayer)
        {
            MovePlayer();
        }
        if (Input.GetButtonDown("Fire1"))
        {
            StartCoroutine(Attak());
        }
        if (currentHealth <= 0)
        {
            GameOver();
        }
    }
}
