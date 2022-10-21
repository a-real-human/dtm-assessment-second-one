using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{

    //how many items there are in the level
    public int Items = 17;
    private int Keys = 1;
    //this allows this script to detect when the items are collected
    
    //method to detect how many items remain
    public void UpdateItems(int ItemsLeft)
    {
        //this counts the amount of items required to be collected before the player is allowed to move on to the next level
        Items += ItemsLeft;
    }
    //method to detect how many keys remain
    public void UpdateKeys(int KeysLeft)
    {
	//updates the keys
        Keys += KeysLeft;
    }

    private void OnTriggerEnter2D(Collider2D other)
        { //deletes the door if all the keys and items are collected in the level
        if (Items == 0 && Keys == 0)
            {
                //this effectively opens the "door" and allows the player to go to the next level
                Destroy(gameObject);
            }
        }
    }
