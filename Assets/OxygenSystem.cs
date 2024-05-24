using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OxygenSystem : MonoBehaviour
{

    public Transform player;
    public float maxOxygen;
    private float currentOxygen;
    public float oxygenDecay;
    public float oxygenRegen;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Transform>();
        currentOxygen = maxOxygen;
    }

    // Update is called once per frame
    void Update()
    {
        if(player.position.y < 20)
        {
            currentOxygen -= oxygenDecay * Time.deltaTime;
        }
        else if(player.position.y >= 20 && currentOxygen != maxOxygen)
        {
            currentOxygen += oxygenRegen * Time.deltaTime;
        }
        Debug.Log("Current Oxygen: " + currentOxygen);
    }
}
