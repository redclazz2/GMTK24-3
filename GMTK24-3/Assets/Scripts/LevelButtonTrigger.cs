using UnityEngine;

public class LevelButtonTrigger : MonoBehaviour
{
    public int broadcastCode = 0;

    public AudioSource audioSource;
    public AudioClip audioClip;

    void OnTriggerEnter2D(Collider2D other){
        if(other.CompareTag("MousePointer")){
            audioSource.PlayOneShot(audioClip);
            BroadcastMessage("LevelButtonClicked", broadcastCode);
            
            Invoke("DestroyButton",1f);
        }
    }

    void DestroyButton(){
        Destroy(gameObject);
    }
}
