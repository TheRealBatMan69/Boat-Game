using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupTreasure : MonoBehaviour
{

    public BoxCollider2D player;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Treasure")
        {
            Debug.Log("Treasure Picked Up!");
        }
    }
}
