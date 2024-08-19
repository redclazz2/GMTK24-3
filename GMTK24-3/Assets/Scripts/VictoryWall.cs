using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

public class VictoryWall : MonoBehaviour
{
    public string targetTag = "Box"; // The tag of the objects that should be destroyed
    public string sceneTarget = "Level2";

    private int numberOfBoxesInLevel = -1;

    public int numberOfBoxesDelivered = 0;

    void Start (){
        numberOfBoxesInLevel = GameObject.FindGameObjectsWithTag(targetTag).Length;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag(targetTag))
        {
            numberOfBoxesDelivered ++;
            Destroy(other.gameObject);
        }
    }

    void Update()
    {
        if (numberOfBoxesInLevel == numberOfBoxesDelivered)
        {
            SceneManager.LoadScene(sceneTarget);
        }
    }
}
