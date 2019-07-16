using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireMovement1 : MonoBehaviour {

    public GameObject Fire1;
    Transform mytransform;
    private Vector3 startpos;
    private Vector3 endpos;

    private bool keyhit = false;

	// Use this for initialization
	void Start () {
        startpos = new Vector3(0, -100, 7);
        endpos = new Vector3(157, 12, 97);
        mytransform = GetComponent<Transform>();
        Fire1.transform.position = startpos;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("p"))
            keyhit = true;
        if (keyhit == true)
            Fire1.transform.position = endpos;
	}
}
