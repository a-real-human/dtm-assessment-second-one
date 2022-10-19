using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//to use the scenes stuff i need this

using UnityEngine.SceneManagement;
public class GoToStart : MonoBehaviour
{
    void Start()
    {
        //Start the coroutine we define below named coroutine10s.
        StartCoroutine(coroutine10s());
    }

    IEnumerator coroutine10s()
    {
        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(10);
        SceneManager.LoadScene("start menu", LoadSceneMode.Single);
    }
}