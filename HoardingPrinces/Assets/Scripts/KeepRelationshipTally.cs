using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class KeepRelationshipTally : MonoBehaviour {


	public GameObject ThymeD1;
	public GameObject ThymeD2;
	public GameObject ThymeD3; 
	public GameObject MatchaD1;
	public GameObject MatchaD2;
	public GameObject MatchaD3;
	public GameObject PepperD1;
	public GameObject PepperD2;
	public GameObject PepperD3;

	public GameObject ThymeC1;
	public GameObject ThymeC2;
	public GameObject ThymeC3; 
	public GameObject MatchaC1;
	public GameObject MatchaC2;
	public GameObject MatchaC3;
	public GameObject PepperC1;
	public GameObject PepperC2;
	public GameObject PepperC3;

	public GameObject ThymeT1;
	public GameObject ThymeT2;
	public GameObject ThymeT3; 
	public GameObject MatchaT1;
	public GameObject MatchaT2;
	public GameObject MatchaT3;
	public GameObject PepperT1;
	public GameObject PepperT2;
	public GameObject PepperT3;

	public GameObject GameManager; 
	public int DarjeelingThymeEncounter = 0;
	public int DarjeelingMatchaEncounter = 0;
	public int DarjeelingPepperEncounter = 0;

	public int ChrisThymeEncounter = 0;
	public int ChrisMatchaEncounter = 0;
	public int ChrisPepperEncounter = 0;

	public int ThistleThymeEncounter = 0;
	public int ThistleMatchaEncounter = 0;
	public int ThistlePepperEncounter = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		//Update Relationship Variables
		DarjeelingThymeEncounter = GameObject.Find ("GameManager").GetComponent<dialogueSystem> ().DarjeelingAndThymeEncounter;
		DarjeelingMatchaEncounter = GameObject.Find ("GameManager").GetComponent<dialogueSystem> ().DarjeelingAndMatchaEncounter;
		DarjeelingPepperEncounter = GameObject.Find ("GameManager").GetComponent<dialogueSystem> ().DarjeelingAndPepperEncounter;

		ChrisThymeEncounter = GameObject.Find ("GameManager").GetComponent<dialogueSystem> ().ChrisAndThymeEncounter;
		ChrisMatchaEncounter = GameObject.Find ("GameManager").GetComponent<dialogueSystem> ().ChrisAndMatchaEncounter;
		ChrisPepperEncounter = GameObject.Find ("GameManager").GetComponent<dialogueSystem> ().ChrisAndPepperEncounter;

		ThistleThymeEncounter = GameObject.Find ("GameManager").GetComponent<dialogueSystem> ().ThistleAndThymeEncounter;
		ThistleMatchaEncounter = GameObject.Find ("GameManager").GetComponent<dialogueSystem> ().ThistleAndMatchaEncounter;
		ThistlePepperEncounter = GameObject.Find ("GameManager").GetComponent<dialogueSystem> ().ThistleAndPepperEncounter;

		//Update Colors
		if (DarjeelingThymeEncounter == 1) {
			ThymeD1.GetComponent<SpriteRenderer> ().color =(Color.yellow);
		}
		if (DarjeelingThymeEncounter == 2) {
			ThymeD2.GetComponent<SpriteRenderer> ().color =(Color.yellow);
		}
		if (DarjeelingThymeEncounter == 3) {
			ThymeD3.GetComponent<SpriteRenderer> ().color =(Color.yellow);
		}

		if (DarjeelingMatchaEncounter == 1) {
			MatchaD1.GetComponent<SpriteRenderer> ().color =(Color.green);
		}
		if (DarjeelingMatchaEncounter == 2) {
			MatchaD2.GetComponent<SpriteRenderer> ().color =(Color.green);
		}
		if (DarjeelingMatchaEncounter == 3) {
			MatchaD3.GetComponent<SpriteRenderer> ().color =(Color.green);
		}

		if (DarjeelingPepperEncounter == 1) {
			PepperD1.GetComponent<SpriteRenderer> ().color =new Color(1F,0F,1F,1F);
		}
		if (DarjeelingPepperEncounter == 2) {
			PepperD2.GetComponent<SpriteRenderer> ().color =new Color(1F,0F,1F,1F);
		}
		if (DarjeelingPepperEncounter == 3) {
			PepperD3.GetComponent<SpriteRenderer> ().color =new Color(1F,0F,1F,1F);
		}


		if (ChrisThymeEncounter == 1) {
			ThymeC1.GetComponent<SpriteRenderer> ().color =(Color.yellow);
		}
		if (ChrisThymeEncounter == 2) {
			ThymeC2.GetComponent<SpriteRenderer> ().color =(Color.yellow);
		}
		if (ChrisThymeEncounter == 3) {
			ThymeC3.GetComponent<SpriteRenderer> ().color =(Color.yellow);
		}

		if (ChrisMatchaEncounter == 1) {
			MatchaC1.GetComponent<SpriteRenderer> ().color =(Color.green);
		}
		if (ChrisMatchaEncounter == 2) {
			MatchaC2.GetComponent<SpriteRenderer> ().color =(Color.green);
		}
		if (ChrisMatchaEncounter == 3) {
			MatchaC3.GetComponent<SpriteRenderer> ().color =(Color.green);
		}

		if (ChrisPepperEncounter == 1) {
			PepperC1.GetComponent<SpriteRenderer> ().color =new Color(1F,0F,1F,1F);
		}
		if (ChrisPepperEncounter == 2) {
			PepperC2.GetComponent<SpriteRenderer> ().color =new Color(1F,0F,1F,1F);
		}
		if (ChrisPepperEncounter == 3) {
			PepperC3.GetComponent<SpriteRenderer> ().color =new Color(1F,0F,1F,1F);
		}


		if (ThistleThymeEncounter == 1) {
			ThymeT1.GetComponent<SpriteRenderer> ().color =(Color.yellow);
		}
		if (ThistleThymeEncounter == 2) {
			ThymeT2.GetComponent<SpriteRenderer> ().color =(Color.yellow);
		}
		if (ThistleThymeEncounter == 3) {
			ThymeT3.GetComponent<SpriteRenderer> ().color =(Color.yellow);
		}

		if (ThistleMatchaEncounter == 1) {
			MatchaT1.GetComponent<SpriteRenderer> ().color =(Color.green);
		}
		if (ThistleMatchaEncounter == 2) {
			MatchaT2.GetComponent<SpriteRenderer> ().color =(Color.green);
		}
		if (ThistleMatchaEncounter == 3) {
			MatchaT3.GetComponent<SpriteRenderer> ().color =(Color.green);
		}

		if (ThistlePepperEncounter == 1) {
			PepperT1.GetComponent<SpriteRenderer> ().color =new Color(1F,0F,1F,1F);
		}
		if (ThistlePepperEncounter == 2) {
			PepperT2.GetComponent<SpriteRenderer> ().color =new Color(1F,0F,1F,1F);
		}
		if (ThistlePepperEncounter == 3) {
			PepperT3.GetComponent<SpriteRenderer> ().color =new Color(1F,0F,1F,1F);
		}
	}
}
