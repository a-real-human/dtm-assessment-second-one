using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundary : MonoBehaviour
{
    //sets the boundary 
    private float leftBound = -90;
    // update is called once per frame 
    void Update()
    {
        // checks   to see if the object has pass the boundary if it has it will be deleted
        if (transform.position.x < leftBound)
        {
            //destorys the game object
            Destroy(gameObject);
        }
    }
}

