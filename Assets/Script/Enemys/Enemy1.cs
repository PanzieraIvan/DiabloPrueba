using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy1 : MonoBehaviour
{
    [SerializeField] Transform vectorPlayer;
    [SerializeField] Transform shootobject;
    [SerializeField] float rotationSpeedEnemy1 = 20f;
    [SerializeField] float distanceEnemy1 = 18f;


    [SerializeField] private IceBall iceBall;
    [SerializeField] private float timeToShoot = 1f;
    private float curretTimeToShoot;

    public Animator vampireAnimation;

    public int m_enemiesHealth = 100;
    public Slider m_sliderEnemy1;

    public void TakeDamagePlayer(int p_damage = 30)
    {
        if (m_enemiesHealth > 0)
        {
            m_enemiesHealth -= p_damage;
            if (m_enemiesHealth == 0)
            {
                Destroy(gameObject);
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            TakeDamagePlayer();
        }
    }
    private void ShootEnemy1()
    {
        Instantiate(iceBall, shootobject.position, transform.rotation);
        curretTimeToShoot = timeToShoot;
    }
       
        void Update()
    {
        var distancePlayer = vectorPlayer.position - transform.position;
        curretTimeToShoot -= Time.deltaTime;

        if (distanceEnemy1 > distancePlayer.magnitude && (curretTimeToShoot <= 0))
        {
            ShootEnemy1();
  
        }

        m_sliderEnemy1.value = m_enemiesHealth;
    }
}
