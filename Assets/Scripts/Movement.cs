using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    private InpuTcontroller input;
    private SpriteRenderer sprite;
    private Animator animator;
    public bool flipX;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        input = GetComponent<InpuTcontroller>();
        animator = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        if (Mathf.Abs(input.Movement().magnitude) > 0)
        {
            rb.linearVelocity = new Vector2(input.Movement().x, input.Movement().y) * speed;
            animator.SetBool("isWalking", true);
        }
        else
        {
            
            rb.linearVelocity = Vector2.zero;
            animator.SetBool("isWalking", false);
        }

        if (rb.linearVelocityX > 0)
        {
            sprite.flipX = true;
        }
        else if (rb.linearVelocityX < 0)
        {
            sprite.flipX = false;
        }
    } 
}