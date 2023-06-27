using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BruteCharacter : PlayableCharacter
{
    public float currentHealth;
    private bool m_atackPlayer;
    private float attackTime = 2f;
    public bool m_invincible = false;
    public float m_currentInvincible = 1f;
    public float m_currentBrakeSpeed = 1f;
    public AudioSource caminar;
    private bool Hactivo;
    private bool Vactivo;

    public int namberScene;
    

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

        if (Input.GetButtonDown("Horizontal"))
        {
            //if(Vactivo == false)
           // {
                Hactivo = true;
                caminar.Play();
          //  }
            
        }
        if (Input.GetButtonDown("Vertical"))
        {
            //if(Hactivo == false)
           // {
                Vactivo = true;
                caminar.Play();
           // }
            
        }
        if (Input.GetButtonUp("Horizontal"))
        {
            Hactivo = false;

            if(Vactivo==false)
            {
                caminar.Pause();
            }
            
        }
        if (Input.GetButtonUp("Vertical"))
        {
            Vactivo = false;

            if (Hactivo == false)
            {
                caminar.Pause();
            }
            
        }
    }
    
    public void GameOver()
    {
        Debug.Log("Game Over !!");
        //Time.timeScale = 0;
        SceneManager.LoadScene(namberScene);

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
        if (other.gameObject.CompareTag("Enemy2"))
        {
            TakeDamageEnemy1();
            
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

    public void AttakPlayer()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            StartCoroutine(Attak());
        }
    }
    void Update()
    {
        m_slider.value = currentHealth;

        if (!m_atackPlayer)
        {
            MovePlayer();
        }
        AttakPlayer();
        if (currentHealth <= 0)
        {
            GameOver();
        }
    }
}
