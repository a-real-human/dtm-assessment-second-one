using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    //what game object will be followed by the camera
    public GameObject player;
    // Update is called once per frame
    void LateUpdate()
    {
        //follow player
        transform.position = player.transform.position;
    }
}
