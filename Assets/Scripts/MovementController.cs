using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    private bool holdingBall = false;
    PlayerMovement pm;
    PlayerWithBall pwb;
    Rigidbody2D rb;
    ThrowBall tb;
    public LineRenderer lineRenderer;
    float gsTemp;
    public GameObject ball;

    void Start()
    {
        tb = GetComponent<ThrowBall>();
        pm = GetComponent<PlayerMovement>();
        pwb = GetComponent<PlayerWithBall>();
        rb = ball.GetComponent<Rigidbody2D>();
        gsTemp = rb.gravityScale;
    }

    void FixedUpdate()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            holdingBall = !holdingBall;
        }
        pwb.enabled = holdingBall;
        pm.enabled = !holdingBall;
        lineRenderer.enabled = holdingBall;
        if (holdingBall)
        {
            rb.gravityScale = 0;
        }
        else
        {
            rb.gravityScale = gsTemp;
        }

        if (holdingBall && Input.GetMouseButtonDown(0))
        {
            tb.throwB();
        }
    }
}
