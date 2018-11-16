using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.UI;

[RequireComponent(typeof(LightEstimation))]
public class JK_LightEstTest : MonoBehaviour {

    //debug stuff:
    public Text text_obj;
    public float lightEst = 0.5f;
    public Color lightColorEst = Color.cyan;

    //lightestimation component
    LightEstimation m_LightEstimation;


    void Awake()
    {
        m_LightEstimation = GetComponent<LightEstimation>();
    }

    //for checking in editor, does nothing in published build
    private void OnValidate()
    {
        setGlobalLightEst(lightEst, lightColorEst);
    }


    void setGlobalLightEst(float lightVal, Color lightColor)
    {
        // update shader content with estimated light intensity and color
        Shader.SetGlobalFloat("_GlobalLightEstimation", lightVal);
        Shader.SetGlobalColor("_GlobalLightColor", lightColor);
        
        // update directional light with estimated light intensity and color
        GetComponent<Light>().intensity = lightVal;
        GetComponent<Light>().color = lightColor;
        
        //debug print to onscreen text
        text_obj.text = "intensity: " + lightVal.ToString();
        text_obj.color = lightColor;

    }

    // Update is called once per frame
    void Update () {
        setGlobalLightEst(m_LightEstimation.brightness.Value, m_LightEstimation.colorCorrection.Value);
    }
}
