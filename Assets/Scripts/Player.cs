using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    private Rigidbody2D playerRigidBody;
    private Animator playerAnimator;

    public float movementSpeed;
    public float maxSpeed;
    public float speed;
    
    // Use this for initialization
    void Start()
    {

        playerRigidBody = GetComponent<Rigidbody2D>();
        playerAnimator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {

        float vertical = Input.GetAxis("Vertical");

        float horizontal = Input.GetAxis("Horizontal");

        playerRigidBody.velocity = new Vector2(speed * movementSpeed, playerRigidBody.velocity.y);

        playerRigidBody.velocity = new Vector2(speed * movementSpeed, playerRigidBody.velocity.y);

        playerRigidBody.velocity = new Vector2(playerRigidBody.velocity.y, speed * movementSpeed);

        playerRigidBody.velocity = new Vector2(playerRigidBody.velocity.y, speed * movementSpeed);

        if (playerRigidBody.velocity.x > maxSpeed)
        {
            playerRigidBody.velocity = new Vector2(maxSpeed, playerRigidBody.velocity.y);
        }

        if (playerRigidBody.velocity.x < -maxSpeed)
        {
            playerRigidBody.velocity = new Vector2(-maxSpeed, playerRigidBody.velocity.y);
        }

        if (playerRigidBody.velocity.y > maxSpeed)
        {
            playerRigidBody.velocity = new Vector2(playerRigidBody.velocity.y, maxSpeed);
        }

        if (playerRigidBody.velocity.y < -maxSpeed)
        {
            playerRigidBody.velocity = new Vector2(playerRigidBody.velocity.y, -maxSpeed);
        }

        if (vertical == 0 && horizontal == 0)
        {
            playerAnimator.SetInteger("Direction", 0);//Idle
        }
        else if (Input.GetKeyDown("right"))
        {
            playerAnimator.SetInteger("Direction", 2);//Right
        }
        else if (Input.GetKeyDown("left"))
        {
            playerAnimator.SetInteger("Direction", 1);//Left
        }
        else if (Input.GetKeyDown("up"))
        {
            playerAnimator.SetInteger("Direction", 3);//Up
        }
        else if (Input.GetKeyDown("down"))
        {
            playerAnimator.SetInteger("Direction", 4);//Down
        } 
    }
    /*
    void FixedUpdate()
    {

        float horizontal = Input.GetAxis("Horizontal");

        float vertical = Input.GetAxis("Vertical");

        playerRigidBody.velocity = new Vector2(horizontal * movementSpeed, playerRigidBody.velocity.y);

        playerRigidBody.velocity = new Vector2(playerRigidBody.velocity.y, vertical * movementSpeed);

        if (playerRigidBody.velocity.x > maxSpeed)
        {
            playerRigidBody.velocity = new Vector2(maxSpeed, playerRigidBody.velocity.y);
        }

        if (playerRigidBody.velocity.x < -maxSpeed)
        {
            playerRigidBody.velocity = new Vector2(-maxSpeed, playerRigidBody.velocity.y);
        }

        if (playerRigidBody.velocity.y > maxSpeed)
        {
            playerRigidBody.velocity = new Vector2(playerRigidBody.velocity.y, maxSpeed);
        }

        if (playerRigidBody.velocity.y < -maxSpeed)
        {
            playerRigidBody.velocity = new Vector2(playerRigidBody.velocity.y, -maxSpeed);
        }
    }*/
}
