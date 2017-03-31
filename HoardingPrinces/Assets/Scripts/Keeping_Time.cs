using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Keeping_Time : MonoBehaviour {

	Text txt;

	// Use this for initialization
	private float time;
	public int minutes;
	public int seconds;

	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		time = Time.realtimeSinceStartup;

	}

	void OnGUI() {
		minutes = Mathf.FloorToInt(time / 60F);
		seconds = Mathf.FloorToInt(time - minutes * 60);
		//string niceTime = string.Format("{0:00}:{1:00}", minutes, seconds);

		//GUI.Label(new Rect(10,10,250,100), niceTime);

	}
}
