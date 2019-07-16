using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shader : MonoBehaviour {

    Shader shader1;
    Renderer rend;

    // Use this for initialization
    void Start () {
        rend = GetComponent<Renderer>();
        shader1 = Shader.Find("UI/Default");
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey("p"))
            rend.material.shader = shader1;

    }
}
