using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    private bool holdingBall = false;
    PlayerMovement pm;
    PlayerWithBall pwb;

    void Start()
    {
        pm = GetComponent<PlayerMovement>();
        pwb = GetComponent<PlayerWithBall>();
    }

    void FixedUpdate()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            holdingBall = !holdingBall;
        }
        pwb.enabled = holdingBall;
        pm.enabled = !holdingBall;
    }
}
