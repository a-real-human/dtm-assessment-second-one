using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{

    //how many items there are in the level
    public int Items;
    //this allows this script to detect when the items are collected
    public List<GameObject> ItemsAtStart;
    //method to detect how many items remain
    public void UpdateItems(int ItemsLeft)
    {
        //this counts the amount of items required to be collected before the player is allowed to move on to the next level
        Items += ItemsLeft;
    }
    private void OnTriggerEnter2D(Collider2D other)
        { 
        if (Items == 0)
            {
                //this effectively opens the "door" and allows the player to go to the next level
                Destroy(gameObject);
            }
        }
    }
