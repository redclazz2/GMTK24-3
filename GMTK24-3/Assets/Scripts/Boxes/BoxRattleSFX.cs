using UnityEngine;

public class BoxRattleSFX : MonoBehaviour
{
    public ParticleSystem dustParticles;
    public AudioSource audioSource;
    public AudioClip[] audioClipArray;

    AudioClip RandomClip()
    {
        return audioClipArray[Random.Range(0, audioClipArray.Length)];
    }

    void OnCollisionEnter2D(Collision2D other){
        if(!other.collider.CompareTag("MousePointer")){
             dustParticles.Play();
            audioSource.PlayOneShot(RandomClip());
        }
    }
}
