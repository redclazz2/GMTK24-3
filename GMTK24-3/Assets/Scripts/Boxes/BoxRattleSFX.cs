using UnityEngine;

public class BoxRattleSFX : MonoBehaviour
{
    public GameObject dustParticles;
    public AudioSource audioSource;
    public AudioClip[] audioClipArray;

    AudioClip RandomClip()
    {
        return audioClipArray[Random.Range(0, audioClipArray.Length)];
    }

    void OnCollisionEnter2D(Collision2D other){
        if(!other.collider.CompareTag("MousePointer")){
             DustParticlesPlay();
            audioSource.PlayOneShot(RandomClip());
        }
    }

    void DustParticlesPlay()
    {
        var pos = gameObject.transform.position;
        pos.z = -9;
        Instantiate(dustParticles, pos, gameObject.transform.rotation);
    }
}
