using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy2 : MonoBehaviour
{
    [SerializeField] private Transform vectorPlayer;
    [SerializeField] float rotationSpeedEnemy2 = 20f;
    [SerializeField] float speedEnemy2 = 3f;
    [SerializeField] float distanceEnemyPlayer = 18f;
    [SerializeField] float distanceEnemy2 = 0f;

    public Animator enemy2Animation;

    [SerializeField] private Transform m_raycastPoint;
    [SerializeField] private float m_maxDistance;
    [SerializeField] private LayerMask m_raycastLayers;

    public int m_enemiesHealth = 100;
    public Slider m_sliderEnemy2;
    public void TakeDamagePlayer(int p_damage = 30)
    {
        if (m_enemiesHealth > 0)
        {
            m_enemiesHealth -= p_damage;
            if (m_enemiesHealth <= 0)
            {
                Destroy(gameObject);
            }
        }
    }

    //private void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.CompareTag("Player"))
    //    {
    //        TakeDamagePlayer();
    //    }
    //}
    private void move(Vector3 direction)
    {
        transform.position += direction * (speedEnemy2 * Time.deltaTime);
    }
    private void Enemy2Chase()
    {
       
        var diferenceVector = vectorPlayer.position - transform.position;

        if (distanceEnemy2 < diferenceVector.magnitude)
        {
            transform.LookAt(vectorPlayer);
            move(diferenceVector.normalized);
            
        }
    }
   
    void Update()
    {
        var distancePlayer = vectorPlayer.position - transform.position;

        if (distanceEnemyPlayer > distancePlayer.magnitude)
        {
            Enemy2Chase();
            enemy2Animation.SetBool("mOve", true);
        }
        else
        {
            enemy2Animation.SetBool("mOve", false);
        }
        

        if (Input.GetKeyDown(KeyCode.Space))
        {
            DoRayCast();
        }

        m_sliderEnemy2.value = m_enemiesHealth;

    }
    private void DoRayCast()
    {
        bool l_isHitting = Physics.Raycast(m_raycastPoint.position, m_raycastPoint.forward, out RaycastHit l_hit, m_maxDistance, m_raycastLayers);

        if (l_isHitting)
        {
            Debug.Log($"Is hittingh {l_hit.collider.name}");
        }

        
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawLine(m_raycastPoint.position, m_raycastPoint.position + m_raycastPoint.forward * m_maxDistance);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("ssssssss");
            TakeDamagePlayer();
        }
       
    }
   
}
