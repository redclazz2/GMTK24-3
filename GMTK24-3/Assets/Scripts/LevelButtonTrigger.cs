using UnityEngine;

public class LevelButtonTrigger : MonoBehaviour
{
    public int broadcastCode = 0;

    void OnTriggerEnter2D(Collider2D other){
        if(other.CompareTag("MousePointer")){
            BroadcastMessage("LevelButtonClicked", broadcastCode);
        }
    }
}
