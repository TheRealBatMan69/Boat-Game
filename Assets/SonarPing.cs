using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;
using UnityEngine.Rendering.Universal;

public class SonarPing : MonoBehaviour
{

    public MoveLight lightScript;

    public Light2D sonarLight;
    public GameObject sonarCut;

    public float sonarLightRadius;

    public float speed;
    private float cutSpeed;
    public float intensitySpeed;

    private Vector3 scaleChange;

    private bool pingSonar;

    // Start is called before the first frame update
    void Start()
    {
        ResetSonar();
        sonarCut.SetActive(false);
        pingSonar = false;
        cutSpeed = speed * 4;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space") && !pingSonar && lightScript.currentBattery > 10)
        {
            ResetSonar();
            pingSonar = true;
            lightScript.currentBattery -= 10f;
            Debug.Log("Ping!");
        }
    }

    void FixedUpdate()
    {
        if (pingSonar)
        {
            sonarCut.SetActive(true);

            scaleChange = new Vector3(cutSpeed * Time.deltaTime, cutSpeed * Time.deltaTime, 0);
            sonarLight.pointLightInnerRadius += speed * Time.deltaTime;
            sonarLight.pointLightOuterRadius += speed * Time.deltaTime;
            sonarCut.transform.localScale += scaleChange;
            Debug.Log("Sonar Inner: " + sonarLight.pointLightInnerRadius);
            Debug.Log("Sonar Outer: " + sonarLight.pointLightOuterRadius);
            Debug.Log("Sonar Cut x: " + sonarCut.transform.localScale.y);
            Debug.Log("Soanr Cut y: " + sonarCut.transform.localScale.y);
            if (sonarLight.intensity <= 1f)
            {
                sonarLight.intensity += intensitySpeed * Time.deltaTime;
            } 
            if (sonarLight.pointLightOuterRadius >= sonarLightRadius)
            {
                sonarCut.SetActive(false);
                pingSonar = false;
            }
        }
    }

    void ResetSonar()
    {
        sonarLight.intensity = 0f;
        sonarLight.pointLightInnerRadius = 2f;
        sonarLight.pointLightOuterRadius = 2f;
        sonarCut.transform.localScale = new Vector2(0, 0);
    }
}
