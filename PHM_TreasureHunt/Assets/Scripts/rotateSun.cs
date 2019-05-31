using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateSun : MonoBehaviour {

	public GameObject sun;


	void Start () {
		
	}

	void Update () {
		Quaternion startSun = Quaternion.Euler (60f, 30f, 0f);
		Quaternion endSun = startSun * Quaternion.Euler (0f, 180f, 0f);
		sun.transform.rotation = Quaternion.SlerpUnclamped (startSun, endSun, Time.time / 24.0f);

	}
}
