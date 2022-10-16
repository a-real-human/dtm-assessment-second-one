using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //player controlls
    public float horizontalInput;
    //speed variable
    public float speed = 10.0f;
    //player rigidbody
    private Rigidbody2D playerRb;
    //how much force the player jumps with
    public float jumpForce;
    //how much gravity force there is 
    public float gravityModifier;
    //boolian variable to prevent the player from absing the jump mechanic 
    public bool isOnGround = true;
    // Start is called before the first frame update
    void Start()
    {
        //gets the rigidbody component to add gravity force to
        playerRb = GetComponent<Rigidbody2D>();
        //gravity force
        Physics.gravity *= gravityModifier;
    }

    // Update is called once per frame
    void Update()
    {
        //gets player's input 
        horizontalInput = Input.GetAxis("Horizontal");
        //accelerate left or right
        playerRb.AddForce(Vector2.right * horizontalInput * speed, ForceMode2D.Force);
        //jump with a collision detection
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            //adds the jumpforce to the players rigid body (the player)
            playerRb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            //sets the isOnGround variable to false to prevent the playe from abusing the jump mechanic
            isOnGround = false;
        }
    }
    //collion detection
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //sets the isOnGround variable to true allowing the player to jump
        isOnGround = true;
    }
}
