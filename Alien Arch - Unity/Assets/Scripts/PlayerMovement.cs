using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    //Reference to a RigidBody2D component
    private Rigidbody2D physicsBody = null;
    //Speed setting m/s
    public float speed = 1;
    //Jump speed setting m/s
    public float jumpSpeed = 10;
    //Ground sensing stuff
    public Collider2D groundSensor = null;
    public LayerMask groundLayer = 0;


    public void MoveLeft()
    {
        //Make a variable to hold velocity and get the current velocity
        //From the physics component
        Vector2 newVelocity = physicsBody.velocity;
        //Set our velocity to move in the negative x (left) direction
        newVelocity.x = -speed;
        //Update our physics component's velocity to be our newly changed value
        physicsBody.velocity = newVelocity;
    }

    public void MoveRight()
    {
        //Make a variable to hold velocity and get the current velocity
        //From the physics component
        Vector2 newVelocity = physicsBody.velocity;
        //Set our velocity to move in the negative x (left) direction
        newVelocity.x = speed;
        //Update our physics component's velocity to be our newly changed value
        physicsBody.velocity = newVelocity;
    }

    public void Jump()
    {
        if (groundSensor.IsTouchingLayers(groundLayer))
        {
            //Make a variable to hold the velocity and get the
            //Current velocity from the physics component
            Vector2 newVelocity = physicsBody.velocity;
            //Set our velocity to move in the positive y (up) direction
            newVelocity.y = jumpSpeed;
            //Update our physics component velocity to be our newly changed value
            physicsBody.velocity = newVelocity;
        }
    }



    private void Awake()
    {
        physicsBody = GetComponent<Rigidbody2D>();
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
