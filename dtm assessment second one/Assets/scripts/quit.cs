using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quit : MonoBehaviour
{
    //so it will go to the death scene when player collides with the gameobject
    private void OnTriggerEnter2D(Collider2D other)
    {
        
        Application.Quit();
    }
}