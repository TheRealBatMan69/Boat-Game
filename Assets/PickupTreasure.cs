using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PickupTreasure : MonoBehaviour
{

    public BoxCollider2D player;
    public float money;
    public TMP_Text moneyText;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<BoxCollider2D>();
        money = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Treasure")
        {
            money += 50f;
            collision.gameObject.SetActive(false);
            Debug.Log(collision.tag + " Picked Up!");
            Debug.Log("Money: " + money);
        }
        if (collision.tag == "Big Treasure")
        {
            money += 100f;
            collision.gameObject.SetActive(false);
            Debug.Log(collision.tag + " Picked Up!");

        }
        moneyText.text = "£ " + money.ToString("0");
    }
}