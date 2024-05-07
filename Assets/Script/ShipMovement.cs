using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour
{

    public float moveSpeed;

    private Rigidbody2D _RigidBody;

    // Start is called before the first frame update
    void Start()
    {
        _RigidBody = GetComponent<Rigidbody2D>();
    }



    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("a"))
        {
            transform.Translate(new Vector3(-1, 0, 0) * Time.deltaTime * moveSpeed, Space.World);
        }
        if (Input.GetKey("d"))
        {
            transform.Translate(new Vector3(1, 0, 0) * Time.deltaTime * moveSpeed, Space.World);
        }
    }
}
