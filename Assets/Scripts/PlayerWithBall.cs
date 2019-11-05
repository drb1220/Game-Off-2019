using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWithBall : MonoBehaviour
{
    public GameObject ball;
    public float moveSpeed = 0.5f;
    Rigidbody2D rb;
    float gsTemp;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    void FixedUpdate()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += movement * moveSpeed * Time.deltaTime;


        ball.transform.position = transform.position;
    }
}
