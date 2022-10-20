using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weirdEnemy1 : MonoBehaviour
{
    xRange

    // Keeps the player from falling off the platform by detecting if the player is beyond the xRange and stops the playing from moving beyound the xRange
        if (transform.position.x < xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
}
if (transform.position.x > -xRange)
{
    transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
}
void Start()
    {
        StartCoroutine(coroutine10s());
    }


    void Update()
    {
        transform.Translate(Vector2.right * Time.deltaTime * 10 *-1);
        if 
        Destroy(gameObject);
    }

}
