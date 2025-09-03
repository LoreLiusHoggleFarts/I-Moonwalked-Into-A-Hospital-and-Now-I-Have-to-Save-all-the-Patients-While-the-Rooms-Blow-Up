using UnityEngine;
using UnityEngine.InputSystem;

public class InpuTcontroller : MonoBehaviour
{
    public PlayerInput playerInput;

    public InputAction movement;


    private void Awake()
    {
        movement = playerInput.actions["Move"];
    }
    public Vector2 Movement() => movement.ReadValue<Vector2>();
    
    
}
