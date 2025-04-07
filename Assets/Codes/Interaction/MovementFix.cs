using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MovementFix : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 5f;
    private Vector2 moveInput;
    private Rigidbody2D Rb;

    void Start()
    {
        Rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Rb.velocity = moveInput * moveSpeed;
    }

    public void Move(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();
    }
}
