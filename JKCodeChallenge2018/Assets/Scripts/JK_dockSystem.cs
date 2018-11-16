using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JK_dockSystem : MonoBehaviour {

    public GameObject rocket1;
    public GameObject dock1;

	// Use this for initialization
	void Start () {
		
	}

    //function that moves the rocket gameObject to wherever the dock icon is, called by JKDetectTap on the CodeChallengeManager Gameobject
    public void placeRocket(bool placed)
    {
        rocket1.transform.position = dock1.transform.position;
        rocket1.transform.rotation = dock1.transform.rotation;

        //turns off the dock when the rocket is visible
        if (placed)
        {
            rocket1.SetActive(true);
            dock1.SetActive(false);
        }
        //turns off the rocket when the dock is visible
        else
        {
            rocket1.SetActive(false);
            dock1.SetActive(true);
        }
        

    }

    // Update is called once per frame
    void Update () {
    
    }
}
