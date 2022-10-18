using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weirdEnemy1 : MonoBehaviour
{
    private bool Touched = false;

    void Update()
    {
        if (Touched)
             transform.Translate(Vector2.right * Time.deltaTime * 25 *-1);


    }

    IEnumerator coroutine10s()
    {
        //yield on a new YieldInstruction that waits for 10 seconds.
        yield return new WaitForSeconds(10);
        //destroys this game object
        Destroy(gameObject);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
       Touched = true;
       StartCoroutine(coroutine10s());
    }
}
