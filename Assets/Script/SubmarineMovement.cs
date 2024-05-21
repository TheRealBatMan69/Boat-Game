using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubmarineMovement : MonoBehaviour
{
    private Rigidbody2D body;

    // public float velocity;
    public bool isMoving = false;

    public float moveSpeed = 1000f;
    private float moveHorizontal;
    private float moveVertical;

    private float test;
    private float currentPos;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log(body.velocity.y);
        // velocity = body.velocity.y;

        moveHorizontal = Input.GetAxis("Horizontal");
        moveVertical = Input.GetAxis("Vertical");

        float currentPos = transform.position.y;
        if (test == currentPos)
        {
            isMoving = false;
        }
        else
        {
            isMoving = true;
        }
    }

    void FixedUpdate()
    {
        if (transform.position.y > 20)
        {
            transform.position = new Vector3(transform.position.x, 20.0f, transform.position.z);
        }

        body.velocity = new Vector2 (moveHorizontal*moveSpeed*Time.deltaTime, moveVertical*moveSpeed*Time.deltaTime);

        // if (Input.GetKey("a"))
        // {
        //     transform.Translate(new Vector3(-1, 0, 0) * Time.deltaTime * sideSpeed, Space.World);
        // }
        // if (Input.GetKey("d"))
        // {
        //     transform.Translate(new Vector3(1, 0, 0) * Time.deltaTime * sideSpeed, Space.World);
        // }
        // if (Input.GetKey("s"))
        // {
        //     transform.Translate(new Vector3(0, -1, 0) * Time.deltaTime * sideSpeed, Space.World);
        // }
        // if (Input.GetKey("w"))
        // {
        //     transform.Translate(new Vector3(0, 1, 0) * Time.deltaTime * sideSpeed, Space.World);
        // }

        Debug.Log("Last: " + test + "    Current: " + currentPos);
        test = transform.position.y;

    }
}
