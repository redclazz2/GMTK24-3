using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxEnemyDestroy : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other){
        if (other.gameObject.CompareTag("Enemy")){
            Destroy(gameObject);
        }
    }
}
