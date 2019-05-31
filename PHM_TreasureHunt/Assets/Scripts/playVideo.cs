using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Video;


public class playVideo : MonoBehaviour,TimedGaze {
	bool alreadyPlayed = false;
	Camera camera;
	public void playVid(){
		AudioSource audioSource;
		VideoPlayer videoPlayer;
		if (!alreadyPlayed) {
			videoPlayer = GetComponent<VideoPlayer>();
			audioSource = GetComponent<AudioSource>();
			videoPlayer.Play ();	
			audioSource.Play ();
		}
		alreadyPlayed = true;
	}
		
	public void handleTimedInput(){
		AudioSource src;
		src = GetComponent<AudioSource>();
		src.Stop ();
		SceneManager.LoadScene ("Fade");
	}
}
