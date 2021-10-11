using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl2 : MonoBehaviour
{
    private Rigidbody2D rigidBody2D;
    public float speed;
    private KeyCode upButton = KeyCode.W;
    private KeyCode downButton = KeyCode.S;

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
        else
        {
            velocity.x = 5f;
            velocity.y = 5f;
        }
        rigidBody2D.velocity = velocity;
    }
}
