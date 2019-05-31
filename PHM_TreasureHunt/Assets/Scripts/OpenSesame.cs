using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class OpenSesame : MonoBehaviour,TimedGaze {
	public GameObject ui = null;
	public Text upCount = null;
	public int count;

	void Start(){
		count = 0;
	}
		
	public void gone1(){
		count++;
		GameObject.Find ("Lock1").transform.localScale = new Vector3 (0, 0, 0);
		GameObject.Find ("Lid1").transform.localRotation = Quaternion.Euler (0f, -120f, 0f);

		ui.SetActive (true);
		upCount.text = "Chests: " + count + "/3";
	}

	public void gone2(){
		count++;
		GameObject.Find ("Lock2").transform.localScale = new Vector3 (0, 0, 0);
		GameObject.Find ("Lid2").transform.localRotation = Quaternion.Euler (0f, -120f, 0f);

		ui.SetActive (true);
		upCount.text = "Chests: " + count + "/3";

	}

	public void gone3(){
		count++;
		GameObject.Find ("Lock2").transform.localScale = new Vector3 (0, 0, 0);
		GameObject.Find ("Lid2").transform.localRotation = Quaternion.Euler (0f, -120f, 0f);

		ui.SetActive (true);
		upCount.text = "Chests: " + count + "/3";
	}

	public void noWin(){
		if(ui)
			ui.SetActive (false);
	}

	public void handleTimedInput(){
		
	}
}
