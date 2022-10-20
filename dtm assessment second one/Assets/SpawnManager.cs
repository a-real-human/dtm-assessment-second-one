using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private int numOfEnemiesSpawned = 0;
    public GameObject[] enemyPrefabs;
    public float spawnPosX;
    public float spawnRangeY;
    // Start is called before the first frame update
    void Start()
    {
        //starts the coroutine  so that after 10
        StartCoroutine(coroutine10s())
    }
    
    IEnumerator coroutine10s()
    {
        //yield on a new YieldInstruction that waits for 10 seconds.
        yield return new WaitForSeconds(10);
        
        Instantiate(enemyPrefabs, )
        
        StartCoroutine(coroutine15s())


    }
    IEnumerator coroutine15s()
    {
        //yield on a new YieldInstruction that waits for 15 seconds.
        yield return new WaitForSeconds(15);
        Instantiate(enemyPrefabs, )

        private void OnTriggerEnter2D(Collider2D other)
    {
        
        ;
    }
}
