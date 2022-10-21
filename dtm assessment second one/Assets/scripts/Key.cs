using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
	//calls the door script
    private Door door;
    private bool Collected = false;

    public GameObject player;
    public float spawnRangeXPositive;
    public float spawnRangeXNegative;
    public float spawnRangeYPositive;
    public float spawnRangeYNegative;
    public Vector3 offset = new Vector3(-6, 16, 0);
    private bool Beginning = true;
    // Start is called before the first frame update
    void Start()
    {
        //this "talks to" the  door object and allows this script to call a specific component on that object
        door = GameObject.Find("Door").GetComponent<Door>();
        if (Beginning == true)
        {
		//sets the key's position to a random place between set up by the spawnrange
            transform.position = new Vector3(Random.Range(spawnRangeXNegative, spawnRangeXPositive), Random.Range(spawnRangeYNegative, spawnRangeYPositive), 0);
            Beginning = false;
        }
    }


        //detects collisions
        void OnTriggerEnter2D(Collider2D other)
        {	//compares tag of the other object if it has the player tag then it while set to true and do the things below
            if (other.CompareTag("Player"))
            {
                //decreases the number of items left to find in the level
                door.UpdateKeys(-1);
		//collected = true tells the script that the key has been collected and should move up the the top corner of the player screen
                Collected = true;
            }
        }
        void LateUpdate()
        {//collected = true tells the script that the key has been collected and should move up the the top corner of the player screen
            if (Collected) 
            {//follow player with off set 
                  transform.position = player.transform.position + offset;
            }
            
        }
    }


