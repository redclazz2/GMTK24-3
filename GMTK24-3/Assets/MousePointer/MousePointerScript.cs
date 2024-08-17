using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousePointerScript : MonoBehaviour
{
    Rigidbody2D rigidbody2D;
    Transform mousePointerTransform;
    public float scaleFactor = 0.05f;
    public float minScale = 1;
    public float maxScale = 8;
public float stopDistance = 0.1f; // Adjust this value as needed
    public LayerMask obstacleLayer; // LayerMask for obstacles

private Vector2 velocity = Vector2.zero;
public float speed = 5f;
public float smoothTime = 0.1f; // Adjust this value to control the smoothness
    void Start()
    {
        Cursor.visible = false;
        mousePointerTransform = gameObject.GetComponent<Transform>();
        rigidbody2D = gameObject.GetComponent<Rigidbody2D>();

        GetComponent<Rigidbody2D>().collisionDetectionMode = CollisionDetectionMode2D.Continuous;
    }

    void Update()
    {
        //Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //mousePointerTransform.position = mousePosition;

        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    Vector2 targetPosition = Vector2.SmoothDamp(rigidbody2D.position, mousePosition , ref velocity, smoothTime, speed);

    rigidbody2D.MovePosition(targetPosition);

       // Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
     //   mousePosition.z = 0;

      //  Vector3 targetPosition = Vector3.Lerp(transform.position, mousePosition, 5 * Time.deltaTime);
//mousePointerTransform.position = targetPosition;

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

        // Check for obstacles along the path to the target position
        /*Vector3 direction = (targetPosition - transform.position).normalized;
        float distance = Vector3.Distance(transform.position, targetPosition);
        RaycastHit2D hit = Physics2D.Raycast(transform.position, direction, distance, obstacleLayer);
        if (hit.collider != null)
        {
            // Stop at the point where the obstacle is hit
            targetPosition = (Vector3)hit.point - direction * (transform.localScale.x / 2);
        }*/

    }
}
