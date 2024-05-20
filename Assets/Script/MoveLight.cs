using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;
using UnityEngine.Rendering.Universal;

public class MoveLight : MonoBehaviour
{

    public float RotationSpeed;
    public float LightSpeed;
    public Light2D subLight;

    // Start is called before the first frame update
    void Start()
    {
        subLight = GetComponent<Light2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey("right"))
        {
            transform.Rotate(new Vector3(0, 0, RotationSpeed) * Time.deltaTime, Space.World);
        }
        if (Input.GetKey("left"))
        {
            transform.Rotate(new Vector3(0, 0, -RotationSpeed) * Time.deltaTime, Space.World);
        }
        if (Input.GetKey("down") && subLight.pointLightOuterRadius <= 15 && subLight.pointLightInnerRadius <= 11.7)
        {
            subLight.pointLightOuterRadius += Time.deltaTime * LightSpeed;
            subLight.pointLightInnerRadius += Time.deltaTime * LightSpeed;
        }
        if (Input.GetKey("up") && subLight.pointLightOuterRadius >= 7.5 && subLight.pointLightInnerRadius >= 5.85)
        {
            subLight.pointLightOuterRadius -= Time.deltaTime * LightSpeed;
            subLight.pointLightInnerRadius -= Time.deltaTime * LightSpeed;
        }
    }
}
