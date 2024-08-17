using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousePointerScript : MonoBehaviour
{
    Transform mousePointerTransform;

    [SerializeField]
    float scaleFactor = 0.05f;

    [SerializeField]
    float minScale = 1;

    [SerializeField]
    float maxScale = 8;

    void Start()
    {
        Cursor.visible = false;
        mousePointerTransform = gameObject.GetComponent<Transform>();
    }

    void Update()
    {
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePointerTransform.position = mousePosition;

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

    }
}
