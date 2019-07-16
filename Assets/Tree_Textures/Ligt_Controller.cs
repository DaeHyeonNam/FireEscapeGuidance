using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ligt_Controller : MonoBehaviour {

    public string tagName = "EachLight";
    GameObject[] EachLightObjects;
    Light thisLight;

	// Use this for initialization
	void Start () {
        EachLightObjects = GameObject.FindGameObjectsWithTag(tagName);
        thisLight = GetComponent<Light>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey("p"))
        {
            thisLight.intensity = 0.05F;
            foreach (GameObject EachObject in EachLightObjects)
            {
                EachLight eachLight = EachObject.GetComponent<EachLight>();
                eachLight.eachLight = true;
            }
            
        }
	}
}
