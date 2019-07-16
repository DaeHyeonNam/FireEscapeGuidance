using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EachLight : MonoBehaviour {

    public bool eachLight = false;
    Light mylight;
	// Use this for initialization
	void Start () {
        mylight = GetComponent<Light>();
	}
	
	// Update is called once per frame
	void Update () {
    //    if(Input.GetKey("p"))
            mylight.enabled = false;
	}
}
