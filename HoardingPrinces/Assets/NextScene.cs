using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void gameScene(){
		//AutoFade.LoadLevel("MainScene" ,3,1,Color.black);
		Application.LoadLevel ("MainScene");
	}

	public void introScene(){
		//AutoFade.LoadLevel("MainScene" ,3,1,Color.black);
		Application.LoadLevel ("Opening");
	}

	public void InstructionScene(){
		//AutoFade.LoadLevel("MainScene" ,3,1,Color.black);
		Application.LoadLevel ("Instructions");
	}

	public void StartScene(){
		//AutoFade.LoadLevel("MainScene" ,3,1,Color.black);
		Application.LoadLevel ("Start");
	}
}
