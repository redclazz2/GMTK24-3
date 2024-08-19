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

    public Vector3 confettiSpawn;

    public AudioSource audioSource;
    public AudioClip victoryClip;
    public AudioClip levelFinishClip;

    public GameObject confetti;

    void Start (){
        numberOfBoxesInLevel = GameObject.FindGameObjectsWithTag(targetTag).Length;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag(targetTag))
        {
            numberOfBoxesDelivered ++;
            audioSource.PlayOneShot(victoryClip);
            Destroy(other.gameObject);
            Instantiate(confetti, confettiSpawn, Quaternion.identity);

         if (numberOfBoxesInLevel == numberOfBoxesDelivered)
        {
            audioSource.PlayOneShot(levelFinishClip);
            Invoke("ChangeScene",2) ;
        }
        }
    }

    void Update()
    {
        
    }

    private void ChangeScene(){
        SceneManager.LoadScene(sceneTarget);
    }
}
