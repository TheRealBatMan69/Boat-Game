using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class subCollider : MonoBehaviour
{
    private Collider2D _subCollider;
    public float health = 100f;
    public GameObject fish;

    // Start is called before the first frame update
    void Start()
    {
        _subCollider = GetComponent<BoxCollider2D>();

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "player")
        {
            fish.SetActive(false);
        }
    }
    void Update()
    {
        
    }
}
