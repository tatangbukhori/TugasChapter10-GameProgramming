using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl4 : MonoBehaviour
{
    private Rigidbody2D rigidBody2D;
    public float speed;
    public KeyCode upButton = KeyCode.W;
    public KeyCode downButton = KeyCode.S;
    public KeyCode leftButton = KeyCode.A;
    public KeyCode rightButton = KeyCode.D;

    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        Vector2 velocity = rigidBody2D.velocity;
        if (Input.GetKey(upButton))
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

