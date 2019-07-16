using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireMovement : MonoBehaviour {

    public GameObject Fire;
    Transform mytransform;
    private Vector3 startpos;
    private Vector3 endpos;

    private bool keyhit = false;

	// Use this for initialization
	void Start () {
        startpos = new Vector3(0, -100, 7);
        endpos = new Vector3(157, 10, 97);
        mytransform = GetComponent<Transform>();
        Fire.transform.position = startpos;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("p"))
            keyhit = true;
        if (keyhit == true)
            Fire.transform.position = endpos;
	}
}
