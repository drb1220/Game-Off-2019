using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowBall : MonoBehaviour
{
    public float throwSpeed = 10;
    private Vector3 target;
    public Camera cam;
    private Vector2 direction;
    private float rotationZ;
    public LaunchArcRenderer launchArcRenderer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        target = cam.transform.GetComponent<Camera>().ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, transform.position.z));
        Vector3 difference = target - transform.position;
        rotationZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        float distance = difference.magnitude;
        direction = difference / distance;
        direction.Normalize();

        launchArcRenderer.UpdateNumbers(rotationZ);
    }

    public void throwB()
    {
        print(rotationZ);
    }

}
