using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : MonoBehaviour
{
    [SerializeField] private Transform vectorPlayer;
    [SerializeField] float rotationSpeedEnemy2 = 20f;
    [SerializeField] float speedEnemy2 = 3f;
    [SerializeField] float distanceEnemyPlayer = 18f;
    [SerializeField] float distanceEnemy2 = 1f;

    public Animator enemy2Animation;

    [SerializeField] private Transform m_raycastPoint;
    [SerializeField] private float m_maxDistance;
    [SerializeField] private LayerMask m_raycastLayers;

    [SerializeField] public float damageEnemy2 = 5f;

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
    // Update is called once per frame
    void Update()
    {
        var distancePlayer = vectorPlayer.position - transform.position;

        if (distanceEnemyPlayer > distancePlayer.magnitude)
        {
            Enemy2Chase();
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            DoRayCast();
        }

        
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
}
