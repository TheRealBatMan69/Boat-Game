using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fishCollision : MonoBehaviour
{
    private Collider2D _fishCollider;
    public float health = 100f;

    // Start is called before the first frame update
    void Start()
    {
        _fishCollider = GetComponent<BoxCollider2D>();

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "fish")
        {
            health = health - 10f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
