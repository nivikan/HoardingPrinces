using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void gameScene(){
		//AutoFade.LoadLevel("MainScene" ,3,1,Color.black);
		SceneManager.LoadScene ("MainScene");
	}

	public void introScene(){
		//AutoFade.LoadLevel("MainScene" ,3,1,Color.black);
		SceneManager.LoadScene("Opening");
	}

	public void InstructionScene(){
		//AutoFade.LoadLevel("MainScene" ,3,1,Color.black);
		SceneManager.LoadScene("Instructions");
	}

	public void StartScene(){
		//AutoFade.LoadLevel("MainScene" ,3,1,Color.black);
		SceneManager.LoadScene("Start");
	}
}
