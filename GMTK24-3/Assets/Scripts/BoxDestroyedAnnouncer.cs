using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BoxDestroyedAnnouncer : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip tune;

    void Start()
    {
        //musicPlayer.GetComponent<AudioSource>().mute = true;
        Destroy(GameObject.FindGameObjectWithTag("MusicPlayer"));
        audioSource.PlayOneShot(tune);
        Invoke("RestartLevel",5f);
    }

    void RestartLevel(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
