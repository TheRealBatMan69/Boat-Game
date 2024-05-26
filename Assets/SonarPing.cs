using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;
using UnityEngine.Rendering.Universal;

public class SonarPing : MonoBehaviour
{

    public Light2D sonarLight;
    public GameObject sonarCut;

    public float sonarLightInnerRadius;
    public float sonarLightOuterRadius;
    public Vector2 sonarCutRadius;

    public float speed;
    public float intensitySpeed;

    // Start is called before the first frame update
    void Start()
    {
        sonarLight.intensity = 0f;
        sonarLight.pointLightInnerRadius = 0f;
        sonarLight.pointLightOuterRadius = 0f;
        sonarCut.transform.localScale = new Vector2(0, 0);
        sonarCut.SetActive(false);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown("space"))
        {
            sonarCut.SetActive(true);
            
            Debug.Log("Ping!");
        }
    }
}
