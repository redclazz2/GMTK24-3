using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BoxEnemyDestroy : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip destroyAudioClip;
    void OnCollisionEnter2D(Collision2D other){
        if (other.gameObject.CompareTag("Enemy")){
            audioSource.PlayOneShot(destroyAudioClip);
            Invoke("DestroyBox",0.2f);
        }
    }

    void DestroyBox(){
        Destroy(gameObject);
    }
}
