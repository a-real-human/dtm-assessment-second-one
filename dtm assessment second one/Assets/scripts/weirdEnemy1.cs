using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weirdEnemy1 : MonoBehaviour
{
    IEnumerator coroutine10s()
    {
        transform.Translate(Vector2.right * 100);
        //yield on a new YieldInstruction that waits for 10 seconds.
        yield return new WaitForSeconds(10);
        //destroys this game object
        Destroy(gameObject);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
       StartCoroutine(coroutine10s());
    }
}
