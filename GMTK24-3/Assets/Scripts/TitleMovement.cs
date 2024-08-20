using UnityEngine;

public class TitleMovement : MonoBehaviour
{
    public float speed =10;
    Vector3 startPos;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x - 22 > startPos.x){
            transform.position = startPos;
        }else{
            transform.Translate(Vector3.right * Time.deltaTime * speed);
        }
    }
}
