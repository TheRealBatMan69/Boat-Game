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

    public int minTreasure;
    public int maxTreasure;

    private Transform spawnPoint;
    int treasure;

    // Start is called before the first frame update
    void Start()
    {
        treasure = Random.Range(minTreasure, maxTreasure);

        for(int i = 0, i < treasure, i++)
        {
            SpawnTreasure();
        }
    }

    void SpawnTreasure()
    {
        spawnPoint.position.x = Random.Range(minX, maxX);
        spawnPoint.position.y = Random.Range(minY, maxY);

        Instantiate(treasurePrefab, spawnPoint.position, Quaternion.identity)
    }
}
