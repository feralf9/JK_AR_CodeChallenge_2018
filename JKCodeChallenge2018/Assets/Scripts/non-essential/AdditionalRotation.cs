using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdditionalRotation : MonoBehaviour {

    public int speed = 50;
    int direction;
    int timer = 1000;
    int counter = 0;
    // Use this for initialization
	void Start () {
		
	}
	
    void directionReset ()
    {
        speed = Random.Range(40, 130);
        direction = Random.Range(0, 3);
    }

    // Update is called once per frame
    void Update () {
        counter += Random.Range(1, 10);
        if(counter >= timer)
        {
            directionReset();
        counter = 0;
        }

        if (direction == 0)
        {
            transform.Rotate(Vector3.back * Time.deltaTime * speed);
        }
        else if (direction == 1)
        {
            transform.Rotate(Vector3.down * Time.deltaTime * speed);
        }
        else if (direction == 2)
        {
            transform.Rotate(Vector3.up * Time.deltaTime * speed);
        }
        else if (direction == 3)
        {
            transform.Rotate(Vector3.forward * Time.deltaTime * speed);
        }
        print(direction);
    }
}
