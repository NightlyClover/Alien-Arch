using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    //Public variables
    public float forceStrength;
    public Vector2[] patrolPoints;
    public float stopDistance;

    //Private variables
    private Rigidbody2D ourRigidBody;
    private int currentPoint = 0;

    private void Awake()
    {
        //Get the rigidbody attacged to this object for movement
        ourRigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //How far are we from our target
        float distance = (patrolPoints[currentPoint] - (Vector2)transform.position).magnitude;

        //If we are closer to our target than our minimum distance
        if (distance <= stopDistance)
        {
            currentPoint = currentPoint + 1;

            //If we've gone past the end of our list
            if (currentPoint >= patrolPoints.Length)
            {
                //Then loop back to the start
                currentPoint = 0;
            }
        }


        //Get the direction we should move in
        Vector2 direction = (patrolPoints[currentPoint] - (Vector2)transform.position).normalized;

        ourRigidBody.AddForce(direction * forceStrength);
    }
}
