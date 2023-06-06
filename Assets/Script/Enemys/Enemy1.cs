using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy1 : PlayableCharacter
{
    public float currentHealt;
    [SerializeField] Transform vectorPlayer;
    [SerializeField] Transform shootobject;
    
    [SerializeField] float distanceEnemyPlayer = 18f;
    

    [SerializeField] private IceBall iceBall;
    [SerializeField] private float timeToShoot = 1f;
    private float curretTimeToShoot;

    

    

    
    

    private void Awake()
    {
        currentHealt = m_maxHealth;
    }
    public void TakeDamagePlayer(float p_damage = 1 * 0.5f)
    {
        if (currentHealt > 0)
        {
            currentHealt -= p_damage;
            if (currentHealt <= 0)
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
    private void Rotation()
    {
        Vector3 targetOrientation = vectorPlayer.position - transform.position;
        Debug.DrawRay(transform.position, targetOrientation, Color.red);

        Quaternion targetOrientationQuaternion = Quaternion.LookRotation(targetOrientation);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetOrientationQuaternion, Time.deltaTime);
    }

   
       
        void Update()
    {
        var distancePlayer = vectorPlayer.position - transform.position;
        curretTimeToShoot -= Time.deltaTime;

        if (distanceEnemyPlayer > distancePlayer.magnitude && (curretTimeToShoot <= 0))
        {
            ShootEnemy1();
            


        }
        Rotation();
        m_slider.value = currentHealt;
    }
}
