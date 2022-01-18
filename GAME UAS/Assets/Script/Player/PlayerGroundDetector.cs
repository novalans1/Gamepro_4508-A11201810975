using UnityEngine;

public class PlayerGroundDetector : MonoBehaviour
{
    public bool isGround ;
    public string objectTag ;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag(objectTag)) isGround = true;
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag(objectTag)) isGround = false;
    }
}
