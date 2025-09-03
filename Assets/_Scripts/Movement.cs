using System;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] public float speed; 
    private Rigidbody2D rb;
    private Vector2 moveInput;
    public PlayerControls controls;
    private void Awake()
    {
        controls = new PlayerControls();
    }

    void OnEnable()
    {
        controls.Player.Enable();
        controls.Player.Move.performed += ctx => moveInput = ctx.ReadValue<Vector2>();
        controls.Player.Move.canceled += ctx => moveInput = Vector2.zero;
    }

    void OnDisable()
    {
        controls.Player.Move.performed -= ctx => moveInput = ctx.ReadValue<Vector2>();
        controls.Player.Move.canceled -= ctx => moveInput = Vector2.zero;
        controls.Player.Disable();
    }

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            rb.MovePosition((rb.position + moveInput * (2 * speed) * Time.fixedDeltaTime));
        }
        else
        {
            rb.MovePosition(rb.position + moveInput * speed * Time.fixedDeltaTime);
        }
    }

    
}

    

   
