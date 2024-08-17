using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryWall : MonoBehaviour
{
   public string targetTag = "Box"; // The tag of the objects that should be destroyed
public string sceneTarget = "Level2";
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(targetTag))
        {
            // Destroy the colliding object
            Destroy(collision.gameObject);

            // Check if there are any objects left with the target tag
            if (GameObject.FindGameObjectsWithTag(targetTag).Length == 0)
            {
                // Restart the game (reload the scene)
                //SceneManager.LoadScene(sceneName);
                Debug.Log("VICTORT!!!!!!!!");
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("COLLISIONNNNNNN");
        if (other.CompareTag(targetTag))
        {
            Debug.Log("COLLISIONNNNNNN with box");
            Destroy(other.gameObject);
        }
    }

    void Update(){
        Debug.Log(GameObject.FindGameObjectsWithTag(targetTag).Length);

            if (GameObject.FindGameObjectsWithTag(targetTag).Length == 0)
            {
                SceneManager.LoadScene(sceneTarget);
            }
    }
}
