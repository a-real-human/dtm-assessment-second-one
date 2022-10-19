using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//to use the scenes stuff i need this

using UnityEngine.SceneManagement;
public class GoToLVL1 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        SceneManager.LoadScene("lvl 1", LoadSceneMode.Single);
    }
}
