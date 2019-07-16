using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPS_controller : MonoBehaviour {
    public float speed = 12f;
    public float sensitivity = 2f;
    CharacterController player;
    private Rigidbody rbody;

    public GameObject eyes;

    float moveFB;
    float moveLR;

    float rotX;
    float rotY;

	// Use this for initialization
	void Start () {
        player = GetComponent<CharacterController>();
        rbody = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey("p"))
        {
            SoundManager.instance.PlaySound();
        }
        moveFB = Input.GetAxis("Vertical") * speed;
        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey("w"))
            moveFB = 3 * moveFB;
        moveLR = Input.GetAxis("Horizontal") * speed;

        rotX = Input.GetAxis("Mouse X") * sensitivity;
        rotY = Input.GetAxis("Mouse Y") * sensitivity;

        Vector3 movement = new Vector3(moveLR, 0, moveFB);
        transform.Rotate(0, rotX, 0);

        eyes.transform.Rotate(-1*rotY, 0, 0);
        movement = transform.rotation * movement;
        player.Move(movement * Time.deltaTime);

        rbody.AddForce(moveFB, 0f, moveLR);
	}
}
