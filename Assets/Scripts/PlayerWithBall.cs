using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWithBall : MonoBehaviour
{
    public GameObject ball;
    public float moveSpeed = 0.5f;
    CircleCollider2D ballCollider;
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        ballCollider = ball.GetComponent<CircleCollider2D>();
        ballCollider.isTrigger
    }

    void FixedUpdate()
    {
        ball.transform.position = transform.position;
    }
}
