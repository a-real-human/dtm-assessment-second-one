using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weirdEnemy1 : MonoBehaviour
{

    void Update()
    {
    transform.Translate(Vector2.right * Time.deltaTime * 20 * -1);
    }


}
