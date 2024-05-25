using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupTreasure : MonoBehaviour
{

    public BoxCollider2D player;
    private int questTracker;


    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<BoxCollider2D>();
        questTracker = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Treasure")
        {
            questTracker++;
            collision.gameObject.SetActive(false);
            Debug.Log("Picked Up!");
            Debug.Log("Quest Tracker: " + questTracker);
        }
    }
}
