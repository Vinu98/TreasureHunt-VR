using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buoy : MonoBehaviour {
	float x;
	float hover;
	Vector3 pos = new Vector3();
	void Start () {
		pos = transform.position;
		x = transform.position.x;
	}

	void Update () {
		hover = (float)(Mathf.Sin (Time.time * Mathf.PI) * 0.5);
		transform.Rotate(new Vector3(0, 0, hover), Space.World);

	}
}
