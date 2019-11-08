using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NearbyScript : MonoBehaviour
{
    public MovementController mc;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.CompareTag("Player"))
        {
            mc.ChangeNearby(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            mc.ChangeNearby(false);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        print("No");
    }
}
