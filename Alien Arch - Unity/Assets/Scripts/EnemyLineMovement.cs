using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLineMovement : MonoBehaviour
{
    //Public variables
    public float forceStrength;
    public Vector2 direction;

    //Private variables
    private Rigidbody2D ourRigidBody;

    //Awake is called when the script is first loaded
    private void Awake()
    {
        //Get and store the rigidbody to be used for movement
        ourRigidBody = GetComponent<Rigidbody2D>();

        //Normalise our direction
        direction = direction.normalized;
    }

    // Update is called once per frame
    void Update()
    {
        //Move in the correct direction with the set force strength
        ourRigidBody.AddForce(direction * forceStrength);
    }
}
