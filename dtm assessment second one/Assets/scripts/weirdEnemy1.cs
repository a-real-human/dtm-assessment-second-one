using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weirdEnemy1 : MonoBehaviour
{
	//update is called once per frame
    void Update()
    {
	//moves right to left 
    	transform.Translate(Vector2.right * Time.deltaTime * 20 * -1);
    }


}
