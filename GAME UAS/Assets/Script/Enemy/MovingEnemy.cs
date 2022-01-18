using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingEnemy : MonoBehaviour
{
    private Animator anim ;
    public float moveSpeed;
    private bool move, back;
    public Vector3 moveTo;
    private Vector3 startPoint;
    private Vector2 velocity = Vector2.zero;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        startPoint = transform.position;
        back = true;
        moveTo = transform.position + moveTo;
        StartCoroutine(Move());
    }

    void Update() 
    {
        if (move) 
        {
            if (!back) transform.position = Vector2.SmoothDamp(transform.position, moveTo, ref velocity, 0, moveSpeed);
            else transform.position = Vector2.SmoothDamp(transform.position, startPoint, ref velocity, 0, moveSpeed);
        }
        
    }

    IEnumerator Move() 
    {
        anim.SetBool("Run", false);
        move = false;

        yield return new WaitForSeconds(2);

        back = !back;
        GetComponent<SpriteRenderer>().flipX = !GetComponent<SpriteRenderer>().flipX;
        anim.SetBool("Run", true);
        move = true;

        yield return new WaitForSeconds(2);
        
        StartCoroutine(Move());
    }
}
