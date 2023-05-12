using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemysSpawner : MonoBehaviour
{
    [SerializeField] private Enemy1 m_enemy1;
    [SerializeField] List<Enemy1> m_enemy1List;
    [SerializeField] private List<Transform> m_spawnPositionsEnemy1;


    [SerializeField] private Enemy2 m_enemy2;
    [SerializeField] List<Enemy2> m_enemy2List;
    [SerializeField] private List<Transform> m_spawnPositionsEnemy2;

    private Transform GetRandomPositionEnemy1()
    {
        int l_randomEnemys1 = Random.Range(0, m_spawnPositionsEnemy1.Count);
        return m_spawnPositionsEnemy1[l_randomEnemys1];
    }

    private void InstantiateAllEnemy1()
    {
        foreach (Enemy1 l_enemy1 in m_enemy1List)
        {
            Transform l_spawnTransform = GetRandomPositionEnemy1();
            Instantiate(l_enemy1, l_spawnTransform.position, Quaternion.identity);
        }
    }

    private Transform GetRandomPositionEnemy2()
    {
        int l_randomEnemys2 = Random.Range(0, m_spawnPositionsEnemy2.Count);
        return m_spawnPositionsEnemy2[l_randomEnemys2];
    }

    private void InstantiateAllEnemy2()
    {
        foreach (Enemy2 l_enemy2 in m_enemy2List)
        {
            Transform l_spawnTransform = GetRandomPositionEnemy2();
            Instantiate(l_enemy2, l_spawnTransform.position, Quaternion.identity);
        }
    }

    private void Awake()
    {
        InstantiateAllEnemy1();
        InstantiateAllEnemy2();
    }
}