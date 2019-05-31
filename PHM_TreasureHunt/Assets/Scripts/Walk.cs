using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walk : MonoBehaviour {

	public Transform cam;
	public float toggleWalkAngle = 30.0f;
	public float speed = 2.0f;
	public CharacterController phm;
	void Start () {
		phm = GetComponentInParent<CharacterController> ();
	}

	void Update () {
		if (cam.eulerAngles.x >= toggleWalkAngle && cam.eulerAngles.x <= 90.0f && (cam.position.y > 9.0f || cam.position.y < 4.0f)) {
			Vector3 forward = cam.TransformDirection (Vector3.forward);
			phm.SimpleMove (forward * speed);
		}
	}

}
