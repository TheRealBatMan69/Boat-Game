using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSpawner : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] enemysPrefabs;
    int randomSpawn;
    int randomEnemy;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy", 5f, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnEnemy()
    {
        Debug.Log("spawn");
        //get random spawn ponts
        randomSpawn = Random.Range(0, spawnPoints.Length);
        randomEnemy = Random.Range(0, enemysPrefabs.Length);
        Instantiate(enemysPrefabs[randomEnemy], spawnPoints[randomSpawn].position, Quaternion.identity);
    }
}
