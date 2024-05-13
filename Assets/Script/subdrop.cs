using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class subdrop : MonoBehaviour
{
    private Rigidbody2D _RigidBody;
    public float sinkSpeed;


    // Start is called before the first frame update
    void Start()
    {
        _RigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("space"))
        {
            _RigidBody.AddForce(Vector2.down * sinkSpeed);
        }
    }
}
