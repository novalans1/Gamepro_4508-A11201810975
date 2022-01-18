using UnityEngine;

public class Poin : MonoBehaviour
{
    public int addPoin = 0;
    public AudioClip sound;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            FindObjectOfType<Point>().AddPoint(addPoin);
            AudioSource.PlayClipAtPoint(sound, transform.position, 0.8f);
            Destroy(gameObject);
        }
    }
}
