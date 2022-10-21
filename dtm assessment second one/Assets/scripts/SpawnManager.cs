using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
	//lets me add what prefabs i want to spawn for future proofing as it allows me to add more enemies in the future if i wanted to.
	public GameObject[] enemyPrefabs;
	//sets time to start spawning in the enemies after the start of the game i have it set to 5 meaning that they start spawning in after 5 secondsa into the game
	private float startDelay = 5;
	// sets the spawn frequency
	private float spawnInterval = 3;
	// Start is called before the first frame update
    	void Start()
    	{
		//repeats the method spawnenemy after 5 seconds every 3
        	InvokeRepeating("SpawnEnemy", startDelay, spawnInterval);
    	}
    	void SpawnEnemy()
    	{
 		//spawns in enemies at a random y position so that the can move across the map and hit the player.
 	       Instantiate(enemyPrefabs[0], new Vector3(100, Random.Range(-32, 48), 0), enemyPrefabs[0].transform.rotation);

    	}
}
