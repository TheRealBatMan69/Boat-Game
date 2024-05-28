using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreasureSpawner : MonoBehaviour
{
    public int minX;
    public int maxX;
    public int minY;
    public int maxY;

    public GameObject treasurePrefab;
    public GameObject bigTreasurePrefab;

    public int minTreasure;
    public int maxTreasure;

    Vector2 spawnPoint;
    int treasure;

    // Start is called before the first frame update
    void Start()
    {
        treasure = Random.Range(minTreasure, maxTreasure);

        for(int i = 0; i < treasure; i++)
        {
            SpawnTreasure();
        }

        Debug.Log("Big Treasure Spawned");
        spawnPoint.x = Random.Range(minX, maxX);
        spawnPoint.y = -78.3f;

        GameObject bigTreasure = Instantiate(bigTreasurePrefab, spawnPoint, Quaternion.identity);
    }

    void SpawnTreasure()
    {
        Debug.Log("Treasure Spawned");
        spawnPoint.x = Random.Range(minX, maxX);
        spawnPoint.y = Random.Range(minY, maxY);

        Instantiate(treasurePrefab, spawnPoint, Quaternion.identity);
    }
}
