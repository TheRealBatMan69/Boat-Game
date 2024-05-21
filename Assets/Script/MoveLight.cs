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
 

    private Vector3 mousePos;
    // Start is called before the first frame update
    void Start()
    {
        subLight = GetComponent<Light2D>();
    }

    // Update is called once per frame
    void Update()
    {
        mousePos = Input.mousePosition;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);

        Vector2 direction = new Vector2(mousePos.x - transform.position.x, mousePos.y - transform.position.y);

        transform.up = direction;

        if (Input.mouseScrollDelta.y < 0 && subLight.pointLightOuterRadius <= 15 && subLight.pointLightInnerRadius <= 13.35)
        {
            subLight.pointLightOuterRadius += LightSpeed;
            subLight.pointLightInnerRadius += LightSpeed;
        }
        if (Input.mouseScrollDelta.y > 0 && subLight.pointLightOuterRadius >= 7.5 && subLight.pointLightInnerRadius >= 5.85)
        {
            subLight.pointLightOuterRadius -= LightSpeed;
            subLight.pointLightInnerRadius -= LightSpeed;
        }
    }
}
