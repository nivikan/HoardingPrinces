﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkipOpening : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("space")) {
			print ("space key was pressed");
			Application.LoadLevel ("MainScene");
		}
	}
}
