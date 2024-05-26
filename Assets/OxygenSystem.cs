using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OxygenSystem : MonoBehaviour
{

    public Transform player;
    public float maxOxygen;
    private float currentOxygen;
    public float oxygenDecay;
    public float oxygenRegen;

    public Slider oxygenSlider;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Transform>();
        currentOxygen = maxOxygen;
        oxygenSlider.maxValue = maxOxygen;
        oxygenSlider.value = maxOxygen;
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
        
        oxygenSlider.value = currentOxygen;

        if(currentOxygen <= 0)
        {
            Debug.Log("Dead");
        }
        //Debug.Log("Current Oxygen: " + currentOxygen);
    }
}
