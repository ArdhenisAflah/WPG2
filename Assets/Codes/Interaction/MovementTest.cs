using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementTest : MonoBehaviour
{
    // Variables
    [SerializeField]
    private float MoveSpeed = 3;
    private BoxCollider2D z_BoxCollider;

    void Start()
    {
        z_BoxCollider = GetComponent<BoxCollider2D>();
    }

    void FixedUpdate()
    {
        Movement();
    }

    private void Movement()
    {
        // Get X & Y input
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        // Cache it in a vector
        Vector2 moveDelta = new Vector2(moveX, moveY);
        
        // Flip the player according to the movement direction
        if(moveDelta.x > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        else if (moveDelta.x < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
        
        // Collision Check
        RaycastHit2D castResult;
        
        // Check if we hit something in the X Axis
        castResult = Physics2D.BoxCast(transform.position, z_BoxCollider.size, 0, new Vector2(moveX, 0), Mathf.Abs(moveX * Time.fixedDeltaTime * MoveSpeed), LayerMask.GetMask("BlockMove"));
        if(castResult.collider)
        {
            // STOP MOVING IN THE X AXIS
            moveDelta.x = 0;
        }

        // Check if we hit something in the Y Axis
        castResult = Physics2D.BoxCast(transform.position, z_BoxCollider.size, 0, new Vector2(0, moveY), Mathf.Abs(moveY * Time.fixedDeltaTime * MoveSpeed), LayerMask.GetMask("BlockMove"));
        if(castResult.collider)
        {
            // STOP MOVING IN THE Y AXIS
            moveDelta.y = 0;
        }

        transform.Translate(moveDelta * Time.fixedDeltaTime * MoveSpeed);
    }
}