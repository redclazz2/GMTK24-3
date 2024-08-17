using UnityEngine;

public class MousePointerScript : MonoBehaviour
{
    Rigidbody2D mouseRigidBody2D;
    Transform mousePointerTransform;
    public float scaleFactor = 0.05f;
    public float minScale = 1;
    public float maxScale = 8;
    public float minMass = 1;
    public float maxMass = 100;
    public float speed = 5f;

    void Start()
    {
        Cursor.visible = false;
        mousePointerTransform = gameObject.GetComponent<Transform>();
        mouseRigidBody2D = gameObject.GetComponent<Rigidbody2D>();

        GetComponent<Rigidbody2D>().collisionDetectionMode = CollisionDetectionMode2D.Continuous;
    }

    void Update()
    {
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 targetPosition = Vector2.Lerp(mouseRigidBody2D.position, mousePosition, speed * Time.deltaTime);

        mouseRigidBody2D.MovePosition(targetPosition);

        var scaleX = mousePointerTransform.localScale.x;
        var scaleY = mousePointerTransform.localScale.y;

        if (Input.GetKey(KeyCode.W))
        {
            if (mousePointerTransform.localScale.x < maxScale)
            {
                mousePointerTransform.localScale = new Vector2(scaleX + scaleFactor, scaleY + scaleFactor);
            }
            else
            {
                mousePointerTransform.localScale = new Vector2(maxScale, maxScale);
            }
        }

        if (Input.GetKey(KeyCode.S))
        {
            if (mousePointerTransform.localScale.x > minScale)
            {
                mousePointerTransform.localScale = new Vector2(scaleX - scaleFactor, scaleY - scaleFactor);
            }
            else
            {
                mousePointerTransform.localScale = new Vector2(minScale, minScale);
            }
        }

        mouseRigidBody2D.mass = mousePointerTransform.localScale.x;
        if(mouseRigidBody2D.mass > maxMass){
            mouseRigidBody2D.mass = maxMass;
        }

        if(mouseRigidBody2D.mass < minMass){
            mouseRigidBody2D.mass = minMass;
        }
    }
}
