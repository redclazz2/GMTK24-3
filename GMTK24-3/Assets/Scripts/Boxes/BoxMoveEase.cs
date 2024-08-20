using UnityEngine;

public class BoxMoveEase : MonoBehaviour
{
    public float forceMultiplier = 10f;
    public float requiredMass = 0;
    Rigidbody2D boxRigidBody2D;

    void Start()
    {
        boxRigidBody2D = gameObject.GetComponent<Rigidbody2D>();
    }

    void OnCollisionEnter(Collision collision)
    {
        Rigidbody otherRb = collision.rigidbody;

        if (otherRb != null && otherRb.mass >= requiredMass)
        {
            // Instead of using collision.impulse, you apply a custom force
            Vector3 customForce = new Vector3(0, 1, 0) * (otherRb.mass * forceMultiplier);
            boxRigidBody2D.AddForce(customForce, ForceMode2D.Impulse);
        }
    }
}
