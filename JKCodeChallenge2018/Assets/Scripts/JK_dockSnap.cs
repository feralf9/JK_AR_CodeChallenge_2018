using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.Experimental.XR;
using UnityEngine.XR.ARFoundation;

[RequireComponent(typeof(ARSessionOrigin))]

public class JK_dockSnap : MonoBehaviour {

    ARSessionOrigin m_SessionOrigin;
    public GameObject dock;

    static List<ARRaycastHit> s_Hits = new List<ARRaycastHit>();

    void Awake ()
    {
        m_SessionOrigin = GetComponent<ARSessionOrigin>();
    }

    // Use this for initialization
    void Start () {
		
	}


    // Update is called once per frame
    void Update()
    {
        
        if (m_SessionOrigin.Raycast(new Vector2(Screen.width * 0.5f, Screen.height * 0.5f), s_Hits, TrackableType.All)) {
            Pose hitPose = s_Hits[0].pose;
            dock.transform.position = hitPose.position;
            dock.transform.rotation = hitPose.rotation;
        }
        else
        {
            dock.transform.position = new Vector3(0.0f, 100.5f, 0.0f);
        }

    }
    
}
