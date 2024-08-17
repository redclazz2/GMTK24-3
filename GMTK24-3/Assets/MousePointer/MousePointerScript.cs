using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousePointerScript : MonoBehaviour
{
    Transform mousePointerTransform;

    void Start()
    {
        Cursor.visible = false;
        mousePointerTransform = gameObject.GetComponent<Transform>();    
    }

    // Update is called once per frame
    void Update()
    {   
        //Vector3 mousePosition = Input.mousePosition;
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePointerTransform.position = mousePosition;

        var scroll =  Input.GetAxis("Mouse ScrollWheel");

        if (scroll != 0) {
            //WeaponNumber += Mathf.FloorToInt(Input.GetAxis("Mouse ScrollWheel") * 10));
            Debug.Log(scroll);

            var scaleX = mousePointerTransform.localScale.x;
            var scaleY = mousePointerTransform.localScale.y; 

            if(scroll > 0){
                //Bigger
                mousePointerTransform.localScale = new Vector2(scaleX + 0.1f,scaleY + 0.1f);
            }else{
               mousePointerTransform.localScale = new Vector2(scaleX - 0.1f,scaleY - 0.1f);
            }
        }
    }
}
