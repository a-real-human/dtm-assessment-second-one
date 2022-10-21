using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // animation  controller i need this to switch between the run animation and the idle animation.
    public Animator animator;
    //tells the game what way the player is facing important because i will use it to flip the player model and animaiton so that the player isnt runing left while looking right
    private bool m_FacingRight = true;
    //player controls
    public float horizontalInput;
    //speed variable
    public float speed = 10.0f;
    //player rigidbody
    private Rigidbody2D playerRb;
    //how much force the player jumps with
    private float jumpForce = 75.0f;
    //how much gravity force there is 
    private float gravityModifier = 10.0f;
    //boolian variable to prevent the player from abusing the jump mechanic 
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
	//the mathf.Abs makes speed always positive which is important as it has to be above 0.001 for the run animation to trigger if you ran left your speed would be a negative number and the idle animation would play so this makes it positive and the run animaiton play
        animator.SetFloat("Speed", Mathf.Abs(horizontalInput));
        //move left or right
        transform.Translate(Vector2.right * Time.deltaTime * speed * horizontalInput);
        //jump with a collision detection
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            //adds the jumpforce to the players rigid body (the player)
            playerRb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            //sets the isOnGround variable to false to prevent the playe from abusing the jump mechanic
            isOnGround = false;
        }

        // If the input is moving the player right and the player is facing left...
        if (horizontalInput  > 0 && !m_FacingRight)
        {
            //  flip the player.
            Flip();
        }
        // Otherwise if the input is moving the player left and the player is facing right...
        else if (horizontalInput < 0 && m_FacingRight)
        {
            //  flip the player.
            Flip();
        }

    }
    
    private void Flip()
    {
        // Switch the way the player is labelled as facing
        m_FacingRight = !m_FacingRight;
        // Multiply the player's x local scale by -1.
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
    //collion detection
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //sets the isOnGround variable to true allowing the player to jump
        isOnGround = true;
    }
}
