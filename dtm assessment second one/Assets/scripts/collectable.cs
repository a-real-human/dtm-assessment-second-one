using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectable : MonoBehaviour

{
    //this allows this script to "talk to" another script
    private GameManager gameManager;
    //calls the door script
    private Door door;
    // Start is called before the first frame update
    void Start()
    {
        //this "talks to" the gamemanager object and allows this script to call a specific component  on that object
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        //this "talks to" the  gateway object and allows this script to call a specific component on that object
        door = GameObject.Find("Door").GetComponent<Door>();
    }
    //detects collisions
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            //decreases the number of items left to find in the level
            door.UpdateItems(-1);
            //increases the score
            gameManager.UpdateScore(1);
            //destroyes the item
            Destroy(gameObject);
        }
    }
}