using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxDrag : MonoBehaviour
{
    private Vector2 difference = Vector2.zero;
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.collisionDetectionMode = CollisionDetectionMode2D.Continuous;
    }

    private void OnMouseDown()
    {
        difference = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition) - (Vector2)transform.position;
    }

    private void OnMouseDrag()
    { 
        Vector2 newPosition = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition) - difference;

        // Mover la caja a través de la física en lugar de simplemente cambiar su posición
        rb.MovePosition(newPosition);
    }

    private void OnMouseUp()
    {
        rb.isKinematic = false; // Reactivar la física cuando se suelta la caja
    }
}
