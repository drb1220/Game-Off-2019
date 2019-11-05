using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    private bool holdingBall = false;
    PlayerMovement pm;
    PlayerWithBall pwb;
    Rigidbody2D rb;
    float gsTemp;
    public GameObject ball;

    void Start()
    {
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
        if (holdingBall)
        {
            rb.gravityScale = 0;
        }
        else
        {
            rb.gravityScale = gsTemp;
        }
    }
}
