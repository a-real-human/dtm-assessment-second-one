using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//to use the scenes stuff i need this
using UnityEngine.SceneManagement;
public class GoToTutorial : MonoBehaviour
{	//detedcts collisions 
    private void OnTriggerEnter2D(Collider2D other)
    {//go to scene tutorial on collision
        SceneManager.LoadScene("tutorial", LoadSceneMode.Single);
    }
}
