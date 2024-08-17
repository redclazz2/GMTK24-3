using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryWall : MonoBehaviour
{
    public string targetTag = "Box"; // The tag of the objects that should be destroyed
    public string sceneTarget = "Level2";
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag(targetTag))
        {
            Destroy(other.gameObject);
        }
    }

    void Update()
    {
        if (GameObject.FindGameObjectsWithTag(targetTag).Length == 0)
        {
            SceneManager.LoadScene(sceneTarget);
        }
    }
}
