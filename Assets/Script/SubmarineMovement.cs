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

    private Rigidbody2D _RigidBody;

    // Start is called before the first frame update
    void Start()
    {
        _RigidBody = GetComponent<Rigidbody2D>();
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
        if (Input.GetKey("a"))
        {
            transform.Translate(new Vector3(-1, 0, 0) * Time.deltaTime * sideSpeed, Space.World);
        }
        if (Input.GetKey("d"))
        {
            transform.Translate(new Vector3(1, 0, 0) * Time.deltaTime * sideSpeed, Space.World);
        }
        if (Input.GetKey("space") && !thrusterWait)
        {
            _RigidBody.AddForce(Vector2.up * thrusterSpeed);
            thrusterWait = true;
        }
    }
}
