using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour {
    Shader shader1;
    // Use this for initialization
    void Start () {
        this.GetComponent<Light>().enabled = false;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey("p"))
        {
            this.GetComponent<Light>().enabled = true;
            Renderer rend = this.GetComponent<Renderer>();
            shader1 = Shader.Find("UI/Default");
            rend.material.shader = shader1;
        }
        if (Input.GetKey("o"))
            this.GetComponent<Light>().enabled = false;

    }
}
