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
    public Vector3 sonarCutRadius;

    public float speed;
    public float intensitySpeed;

    private Vector3 scaleChange;

    private bool pingSonar;

    // Start is called before the first frame update
    void Start()
    {
        sonarLight.intensity = 0f;
        sonarLight.pointLightInnerRadius = 0f;
        sonarLight.pointLightOuterRadius = 0f;
        sonarCut.transform.localScale = new Vector2(0, 0);
        sonarCut.SetActive(false);
        pingSonar = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            Debug.Log("Ping1!");
            pingSonar = true;
            Debug.Log("Ping2!");
        }
    }

    void FixedUpdate()
    {
        if (pingSonar)
        {
            sonarCut.SetActive(true);

            scaleChange = new Vector3(speed * Time.deltaTime, speed * Time.deltaTime, 0);
            sonarLight.pointLightInnerRadius += speed * Time.deltaTime;
            sonarLight.pointLightOuterRadius += speed * Time.deltaTime;
            sonarCut.transform.localScale += scaleChange;
            if (sonarLight.intensity != 1f)
            {
                sonarLight.intensity += intensitySpeed * Time.deltaTime;
            } 
            if (sonarLight.pointLightOuterRadius == sonarLightOuterRadius)
            {
                pingSonar = false;
            }
        }
    }
}
