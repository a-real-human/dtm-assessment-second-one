using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//to use the scenes stuff i need this
using UnityEngine.SceneManagement;

public class Victory : MonoBehaviour
{
	//detects collisions
    private void OnTriggerEnter2D(Collider2D other)
    {	
	//switches to victory scene 
        SceneManager.LoadScene("victory", LoadSceneMode.Single);
    }
}