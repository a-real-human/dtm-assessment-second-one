using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    //what game object will be followed by the camera
    public GameObject player;
    //to offset the camera so the player appears in the middle of the screen
    private Vector3 offset = new Vector3(0, 0, -10);
    // Update is called once per frame
    void LateUpdate()
    {   
        //follow player
        transform.position = player.transform.position + offset;
    }
}
