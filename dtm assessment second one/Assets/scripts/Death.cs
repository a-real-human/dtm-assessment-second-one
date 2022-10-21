using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//to use the scenes stuff i need this
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{

    //so it will go to the death scene when player collides with the gameobject
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            //what scene to load 
            SceneManager.LoadScene("death scene", LoadSceneMode.Single);
        }
    }
}
