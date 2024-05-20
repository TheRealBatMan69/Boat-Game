using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;
using UnityEngine.Rendering.Universal;

public class DepthIntensity : MonoBehaviour
{

    public Light2D GlobalLight;
    public Transform player;

    // Start is called before the first frame update
    void Start()
    {
        GlobalLight = GetComponent<Light2D>();
        GlobalLight.intensity = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        
        GlobalLight.intensity = player.transform.position.y * 0.01f;
        if (GlobalLight.intensity > 1f)
        {
            GlobalLight.intensity = 1f;
        }
    }
}
