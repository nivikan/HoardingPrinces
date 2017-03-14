﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textBoxMounter : MonoBehaviour {

	public GameObject textBox;

	public Text theText;

	public TextAsset textfile;
	public string[] textLines;

	public int currentLine;
	 
	public int endAtLine;

	// Use this for initialization
	void Start () {
		if (textfile != null) {
			textLines = (textfile.text.Split ('\n'));
		}

		if (endAtLine == 0){
			endAtLine = textLines.Length - 1;
		}

	}

	// Update is called once per frame
	void Update () {

		theText.text = textLines[currentLine];

		if (endAtLine < textLines.Length && Input.GetKeyDown (KeyCode.Space)) {
			currentLine++;
		}

		if (currentLine > endAtLine){
			textBox.SetActive(false);
		}
	}
}
