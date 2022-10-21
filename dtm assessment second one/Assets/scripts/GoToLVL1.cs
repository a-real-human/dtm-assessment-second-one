using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//to use the scenes stuff i need this
using UnityEngine.SceneManagement;
public class GoToLVL1 : MonoBehaviour
{//detects collisions
    private void OnTriggerEnter2D(Collider2D other)
    {//go to scene lvl 1
        SceneManager.LoadScene("lvl 1", LoadSceneMode.Single);
    }
}
