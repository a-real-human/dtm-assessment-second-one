using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemyPrefabs;
    public float spawnPosX;
    public float spawnRangeY;
    private float startDelay = 5;
    private float spawnInterval = 3;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy", startDelay, spawnInterval);
        //starts the coroutine  so that after 10
    }
    void SpawnEnemy()
    {
        Instantiate(enemyPrefabs[0], new Vector3(spawnPosX, Random.Range(-spawnRangeY, spawnRangeY), 0), enemyPrefabs[0].transform.rotation);

    }
}
