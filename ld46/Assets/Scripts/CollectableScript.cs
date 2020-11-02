using UnityEngine;

public class CollectableScript : MonoBehaviour
{
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        // static method continues after GO destroyed
        AudioSource.PlayClipAtPoint(audioSource.clip, transform.position);

        Destroy(this.gameObject);
    }

}
