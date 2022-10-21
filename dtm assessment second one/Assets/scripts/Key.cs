using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    private Door door;
    private bool Collected = false;
    public GameObject player;
    public float spawnRangeXPositive;
    public float spawnRangeXNegative;
    public float spawnRangeYPositive;
    public float spawnRangeYNegative;
    private Vector3 offset = new Vector3(-15, 10, 0);
    private bool Beginning = true;
    // Start is called before the first frame update
    void Start()
    {
        //this "talks to" the  gateway object and allows this script to call a specific component on that object
        door = GameObject.Find("Door").GetComponent<Door>();
        if (Beginning == true)
        {
            transform.position = new Vector3(Random.Range(spawnRangeXNegative, spawnRangeXPositive), Random.Range(spawnRangeYNegative, spawnRangeYPositive), 0);
            Beginning = false;
        }
    }


        //detects collisions
        void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Player"))
            {
                //decreases the number of items left to find in the level
                door.UpdateKeys(-1);
                Collected = true;
            }
        }
        void LateUpdate()
        {
            //follow player with off set 
            if (Collected)
            {
                  transform.position = player.transform.position + offset;
            }
            
        }
    }


