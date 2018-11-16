using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

[RequireComponent(typeof(Light))]

public class JK_LightController : MonoBehaviour {

    private Light simLight;
    // Use this for initialization
    void Start () {
        simLight = GetComponent<Light>();
        ARSubsystemManager.cameraFrameReceived += OnCameraFrameReceived;


    }


    void OnCameraFrameReceived(ARCameraFrameEventArgs eventArgs)
    {
        simLight.intensity = eventArgs.lightEstimation.averageBrightness.Value;
        simLight.colorTemperature = eventArgs.lightEstimation.averageColorTemperature.Value;
    }

    void OnDisable()
    {
        ARSubsystemManager.cameraFrameReceived -= OnCameraFrameReceived;
    }

    // Update is called once per frame
    void Update () {
		
	}
    
    
}

