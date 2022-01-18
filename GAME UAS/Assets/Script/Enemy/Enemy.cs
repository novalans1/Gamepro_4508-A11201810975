using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int killPoint; 

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log ("Game Over");
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("PlayerFoot"))
        {
            FindObjectOfType<Point>().AddPoint(killPoint);
            other.transform.parent.GetComponent<Rigidbody2D>().AddForce(Vector2.up*20, ForceMode2D.Impulse);
            Destroy(gameObject);
        }
    }
}
