using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrincessScrpt : MonoBehaviour {

	public Sprite princess1WarningSprite;
	public Sprite princess2WarningSprite;
	public Sprite princess3WarningSprite; 

	public Sprite princess1Sprite;
	public Sprite princess2Sprite;
	public Sprite princess3Sprite; 

	public GameObject castle1PrincessWarning;
	public GameObject castle2PrincessWarning;
	public GameObject castle3PrincessWarning;
	public GameObject castle4PrincessWarning;

	public GameObject Castle1princess;
	public GameObject Castle2princess;
	public GameObject Castle3princess;
	public GameObject Castle4princess;

	public bool princess1OnMap = false;
	public bool princess2OnMap = false;
	public bool princess3OnMap = false;

	// Use this for initialization
	void Start () {

		castle1PrincessWarning = GameObject.Find ("Castle1princessWarning");
		castle2PrincessWarning = GameObject.Find ("Castle2princessWarning");
		castle3PrincessWarning = GameObject.Find ("Castle3princessWarning");
		castle4PrincessWarning = GameObject.Find ("Castle3princessWarning");
		//seconds =  GameObject.Find ("GameManager").GetComponent<Keeping_Time>().seconds;
	}
	
	// Update is called once per frame
	void Update () {
		//seconds =  GameObject.Find ("GameManager").GetComponent<Keeping_Time>().seconds;

		//Check if second is divisible by 4
		//Debug.Log ((seconds/4)%1 == 0);
		//if ((seconds / 4) % 1 == 0) {
		/*
		princess1OnMap = false;
		princess2OnMap = false;
		princess3OnMap = false;
	

		if (castle1PrincessWarning.activeSelf) {
			if (castle1PrincessWarning.GetComponent<SpriteRenderer> ().sprite == princess1WarningSprite)
				princess1OnMap = true;
			else if (castle1PrincessWarning.GetComponent<SpriteRenderer> ().sprite == princess2WarningSprite)
				princess2OnMap = true;
			else if (castle1PrincessWarning.GetComponent<SpriteRenderer> ().sprite == princess3WarningSprite)
				princess3OnMap = true;
		}
		if (castle2PrincessWarning.activeSelf) {
			if (castle2PrincessWarning.GetComponent<SpriteRenderer> ().sprite == princess1WarningSprite)
				princess1OnMap = true;
			else if (castle2PrincessWarning.GetComponent<SpriteRenderer> ().sprite == princess2WarningSprite)
				princess2OnMap = true;
			else if (castle2PrincessWarning.GetComponent<SpriteRenderer> ().sprite == princess3WarningSprite)
				princess3OnMap = true;
		}
		if (castle3PrincessWarning.activeSelf) {
			if (castle3PrincessWarning.GetComponent<SpriteRenderer> ().sprite == princess1WarningSprite)
				princess1OnMap = true;
			else if (castle3PrincessWarning.GetComponent<SpriteRenderer> ().sprite == princess2WarningSprite)
				princess2OnMap = true;
			else if (castle3PrincessWarning.GetComponent<SpriteRenderer> ().sprite == princess3WarningSprite)
				princess3OnMap = true;
		}


		if (Castle1princess.activeSelf) {
			if (Castle1princess.GetComponent<SpriteRenderer> ().sprite == princess1Sprite)
				princess1OnMap = true;
			else if (Castle1princess.GetComponent<SpriteRenderer> ().sprite == princess2Sprite)
				princess2OnMap = true;
			else if (Castle1princess.GetComponent<SpriteRenderer> ().sprite == princess3Sprite)
				princess3OnMap = true;
		}
		if (Castle2princess.activeSelf) {
			if (Castle2princess.GetComponent<SpriteRenderer> ().sprite == princess1Sprite)
				princess1OnMap = true;
			else if (Castle2princess.GetComponent<SpriteRenderer> ().sprite == princess2Sprite)
				princess2OnMap = true;
			else if (Castle2princess.GetComponent<SpriteRenderer> ().sprite == princess3Sprite)
				princess3OnMap = true;
		}
		if (Castle3princess.activeSelf) {
			if (Castle3princess.GetComponent<SpriteRenderer> ().sprite == princess1Sprite)
				princess1OnMap = true;
			else if (Castle3princess.GetComponent<SpriteRenderer> ().sprite == princess2Sprite)
				princess2OnMap = true;
			else if (Castle3princess.GetComponent<SpriteRenderer> ().sprite == princess3Sprite)
				princess3OnMap = true;
		}


*/
		}

	public bool isPrincess1OnMap(){
		return princess1OnMap;
	}

	public bool isPrincess2OnMap(){
		return princess2OnMap;
	}

	public bool isPrincess3OnMap(){
		return princess3OnMap;
	}

}