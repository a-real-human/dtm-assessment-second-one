using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quit : MonoBehaviour
{
    //detects collisions 
    private void OnTriggerEnter2D(Collider2D other)
    {
        //quits the game
        Application.Quit();
    }
}