using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubmarineMovement : MonoBehaviour
{
    public float sideSpeed;
    public float sinkSpeed;
    public float thrusterSpeed;

    private float thrusterTracker = 0;
    public float thrusterWaitTime;
    public bool thrusterWait = false;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (thrusterWait)
        {
            thrusterTracker++;
            if (thrusterTracker == thrusterWaitTime)
            {
                thrusterWait = false;
                thrusterTracker = 0;
            }
        }
    }

    void FixedUpdate()
    {
        //if (transform.position.y > 20)
        //{
        //    transform.position = new Vector3(transform.position.x, 20.0f, transform.position.z);
        //}
        if (Input.GetKey("a"))
        {
            transform.Translate(new Vector3(-1, 0, 0) * Time.deltaTime * sideSpeed, Space.World);
        }
        if (Input.GetKey("d"))
        {
            transform.Translate(new Vector3(1, 0, 0) * Time.deltaTime * sideSpeed, Space.World);
        }
        if (Input.GetKey("s"))
        {
            transform.Translate(new Vector3(0, -1, 0) * Time.deltaTime * sideSpeed, Space.World);
        }
        if (Input.GetKey("w"))// && !thrusterWait)
        {
            transform.Translate(new Vector3(0, 2, 0) * Time.deltaTime * sideSpeed, Space.World);
            //_RigidBody.AddForce(Vector2.up * thrusterSpeed);
            //thrusterWait = true;
        }
    }
}
