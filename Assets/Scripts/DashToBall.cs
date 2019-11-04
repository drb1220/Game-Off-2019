using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashToBall : MonoBehaviour
{
    Rigidbody2D rb;

    public Transform ball;
    public float dashSpeed = 5;
    public float ticks;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            Dash();
        }

    }

    void Dash()
    {
        float x = ball.position.x - transform.position.x;
        float y = ball.position.y - transform.position.y;
        Vector2 d = new Vector2(x * dashSpeed, y * dashSpeed);
        rb.velocity = d;

    }
}