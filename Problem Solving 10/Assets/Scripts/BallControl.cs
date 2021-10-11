using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    private Rigidbody2D rigidBody2D;
    public float speed;
    private float moveSpeed = 10f;
    public KeyCode upButton = KeyCode.W;
    public KeyCode downButton = KeyCode.S;
    public KeyCode leftButton = KeyCode.A;
    public KeyCode rightButton = KeyCode.D;
    private Vector3 mousePosition;


    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        Vector2 velocity = rigidBody2D.velocity;
        if (Input.GetMouseButton(0))
        {
            mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            velocity = (mousePosition - transform.position).normalized;
            rigidBody2D.velocity = new Vector2(velocity.x * moveSpeed, velocity.y * moveSpeed);
        }
        else if (Input.GetKey(upButton))
        {
            velocity.y = speed;
        }
        else if (Input.GetKey(downButton))
        {
            velocity.y = -speed;
        }
        else if (Input.GetKey(leftButton))
        {
            velocity.x = -speed;
        }
        else if (Input.GetKey(rightButton))
        {
            velocity.x = speed;
        }
        else
        {
            rigidBody2D.velocity = Vector2.zero;
            velocity.y = 0.0f;
            velocity.x = 0.0f;
        }
        rigidBody2D.velocity = velocity;
    }
}
