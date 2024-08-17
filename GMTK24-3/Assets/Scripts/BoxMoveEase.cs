using UnityEngine;

public class BoxMoveEase : MonoBehaviour
{
    public float forceMultiplier = 10f;
    Rigidbody2D boxRigidBody2D;

    void Start()
    {
        boxRigidBody2D = gameObject.GetComponent<Rigidbody2D>();
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
}
