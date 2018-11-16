using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JK_detectTap : MonoBehaviour {

    //vars for debug
    public Text text_obj;
    //unused, was going to make a spiral coming off the bottom of the rocket
    public TrailRenderer trail1;
    public Color[] colors = new Color[10];


    //existing objects in scene for rocket and dock icon
    public GameObject rocket;
    public GameObject dock;

    //dockSystem component
    public JK_dockSystem dockControl;

    //bool for toggling between rocket and dock
    bool placed = false;
    
	// Update is called once per frame
	void Update () {
        //if touch exists and is ended - set rocket in place, hide dock
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            placed = !placed;
            //var color1 = Random.Range(0, 9);
           // var color2 = Random.Range(0, 9);
            Touch touch = Input.GetTouch(0);
            text_obj.text = "Touch Position : " + touch.position;
            //trail1.startColor = colors[color1];
            //trail1.endColor = colors[color2];
            dockControl.placeRocket(placed);
            dock.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
        }
        //if touch exists and is started - enlarge dock icon to indicate activation (response feedback)
        else if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            dock.transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
        }

        }
}
