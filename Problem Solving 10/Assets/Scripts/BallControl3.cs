using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl3 : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D rigidBody2D;

    public float xInitialForce;
    public float yInitialForce;
    public float speed;

    void ResetBall()
    {
        transform.position = Vector2.zero;

        rigidBody2D.velocity = Vector2.zero;
    }
    void PushBall()
    {
        float x = Random.Range(0, -2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;
        rigidBody2D.velocity = new Vector2(speed * x, speed * y);
    }
    void RestartGame()
    {
        ResetBall();
        Invoke("PushBall", 2);
    }
    private Vector2 trajectoryOrigin;

    private void OnCollisionExit2D(Collision2D collision)
    {
        trajectoryOrigin = transform.position;
    }
    public Vector2 TrajectoryOrigin
    {
        get { return trajectoryOrigin; }
    }
    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
        RestartGame();
        trajectoryOrigin = transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
