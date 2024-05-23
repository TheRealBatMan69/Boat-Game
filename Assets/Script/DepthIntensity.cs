using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;
using UnityEngine.Rendering.Universal;

public class DepthIntensity : MonoBehaviour
{

    public Light2D GlobalLight;
    public Transform player;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        GlobalLight = GetComponent<Light2D>();
        GlobalLight.intensity = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("s") && GlobalLight.intensity > 0 && rb.velocity.y != 0)
        {
            GlobalLight.intensity -= 0.2f * Time.deltaTime;
        }
        if (Input.GetKey("w") && GlobalLight.intensity < 1 && player.transform.position.y > -30 && rb.velocity.y != 0)
        {
            GlobalLight.intensity += 0.2f * Time.deltaTime;
        }
    }
}
