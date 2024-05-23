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

    public float limitVelocity = 10f;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
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

       if (body.velocity.magnitude > limitVelocity)
       {
           body.velocity = Vector3.ClampMagnitude(body.velocity, limitVelocity);
       }
    }
}
