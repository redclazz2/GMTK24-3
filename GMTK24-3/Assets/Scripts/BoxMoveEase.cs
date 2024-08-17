using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxMoveEase : MonoBehaviour
{
     public float baseDrag = 10f;  // The default drag when no force is applied
    public float minDrag = 0.5f;  // Minimum drag when the heaviest object is colliding
    public float maxMass = 20f;   // The mass that results in the minimum drag

    public float forceMultiplier = 10f;

    Rigidbody2D boxRigidBody2D;
    // Start is called before the first frame update
    void Start()
    {
        boxRigidBody2D = gameObject.GetComponent<Rigidbody2D>();
        boxRigidBody2D.drag = baseDrag;
    }

     void OnCollisionEnter(Collision collision)
    {
        Rigidbody otherRb = collision.rigidbody;

        if (otherRb != null)
        {
            // Calculate and apply force based on the colliding object's mass
            Vector3 force = collision.impulse.normalized * otherRb.mass * forceMultiplier;
            boxRigidBody2D.AddForce(force);
        }
    }

     void OnCollisionExit(Collision collision)
    {
        // Reset the drag when the collision ends
        boxRigidBody2D.drag = baseDrag;
    }
}
