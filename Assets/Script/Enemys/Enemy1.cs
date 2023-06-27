using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1 : PlayableCharacter
{
    public float currentHealt;
    [SerializeField] Transform vectorPlayer;
    [SerializeField] Transform shootobject;
    
    [SerializeField] float distanceEnemyPlayer = 18f;
    

    [SerializeField] private IceBall iceBall;
    [SerializeField] private float timeToShoot = 1f;
    private float curretTimeToShoot;

    

<<<<<<< Updated upstream


=======
    

    

    
    

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

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            TakeDamagePlayer();
        }
    }
>>>>>>> Stashed changes
    private void ShootEnemy1()
    {
        Instantiate(iceBall, shootobject.position, transform.rotation);
        curretTimeToShoot = timeToShoot;

        
    }
<<<<<<< Updated upstream
        // Update is called once per frame
=======
    private void Rotation()
    {
        Vector3 targetOrientation = vectorPlayer.position - transform.position;
        //Debug.DrawRay(transform.position, targetOrientation, Color.red);

        Quaternion targetOrientationQuaternion = Quaternion.LookRotation(targetOrientation);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetOrientationQuaternion, Time.deltaTime);
    }
    private void Slider()
    {
        m_slider.value = currentHealt;
    }
   
       
>>>>>>> Stashed changes
        void Update()
    {
        var distancePlayer = vectorPlayer.position - transform.position;
        curretTimeToShoot -= Time.deltaTime;

        if (distanceEnemyPlayer > distancePlayer.magnitude && (curretTimeToShoot <= 0))
        {
            ShootEnemy1();
<<<<<<< Updated upstream
  
        }
=======
            


        }
        Rotation();
        Slider();
        
>>>>>>> Stashed changes
    }
}
