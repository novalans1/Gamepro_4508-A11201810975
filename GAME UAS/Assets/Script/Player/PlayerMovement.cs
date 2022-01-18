using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public GameObject player;
    public float moveSpeed, jumpPower;
    private Animator anim ;
    private SpriteRenderer image ;
    private Rigidbody2D rb ;
    
    public PlayerGroundDetector ground ;
    public Sprite deadSprite;

    // Start is called before the first frame update
    void Start()
    {
        anim = player.GetComponent<Animator>();
        image = player.GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        anim.SetBool("Run", x != 0 && ground.isGround);
        
        if (x == 1) image.flipX = false;
        else if (x == -1) image.flipX = true;

        rb.velocity = new Vector2(moveSpeed * x, rb.velocity.y);

        if (Input.GetButtonDown("Jump") && ground.isGround)
        {
            rb.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            rb.simulated = false;
            GetComponent<CapsuleCollider2D>().enabled = false;

            anim.SetBool("Dead", true);
            FindObjectOfType<GameControl>().GameOver();
        }
    }
}
