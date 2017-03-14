using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnController : MonoBehaviour {

	public bool isPlayerTurn = true;


	// All princess Sprites we will need
	public Sprite princess1WarningSprite;
	public Sprite princess2WarningSprite;
	public Sprite princess3WarningSprite; 

	public Sprite princess1Sprite;
	public Sprite princess2Sprite;
	public Sprite princess3Sprite; 

	// All CAstle Empty Sprite areas
	public GameObject castle1PrincessWarning;
	public GameObject castle2PrincessWarning;
	public GameObject castle3PrincessWarning;
	public GameObject castle4PrincessWarning;

	public GameObject Castle1princess;
	public GameObject Castle2princess;
	public GameObject Castle3princess;
	public GameObject Castle4princess;

	public GameObject prince1;
	public GameObject prince2;
	public GameObject prince3;

	public int randPrincess;
	public int randCastle;

	public int numPrincesses = 0;


	// Use this for initialization
	void Start () {
		prince1 =  GameObject.Find ("Prince1");
		prince2 =  GameObject.Find ("Prince2");
		prince3 =  GameObject.Find ("Prince3");

	}
	
	// Update is called once per frame
	void Update () {
		

		if (isPlayerTurn == false) {

			Debug.Log ("Not Player Turn");


			//Check if there is any princess currently on the map. If yes, have princess leave the screen

		
			if (Castle1princess.activeSelf) {
				Castle1princess.SetActive (false);
				numPrincesses--;
			}
			if (Castle2princess.activeSelf) {
				Castle2princess.SetActive (false);
				numPrincesses--;
			}
			if (Castle3princess.activeSelf) {
				Castle3princess.SetActive (false);
				numPrincesses--;
			}
			if (Castle4princess.activeSelf) {
				Castle4princess.SetActive (false);
				numPrincesses--;
			}


			//If there are no more than 2 pirincesses on screen + about to be on screen
	
			if (numPrincesses < 2) {

				//CHECK TO SEE IF THERE IS A PRINCESS WARNING ON EACH CASTLE AND IF YES, HAVE PRINCESS VISIT THE CASTLE
				if (castle1PrincessWarning.activeSelf) {
					Sprite castlePrincessWarning = castle1PrincessWarning.GetComponent<SpriteRenderer> ().sprite;
					castle1PrincessWarning.SetActive (false);
					Castle1princess.SetActive(true);
					if (castlePrincessWarning == princess1WarningSprite)
						Castle1princess.GetComponent<SpriteRenderer> ().sprite = princess1Sprite;
					else if (castlePrincessWarning == princess2WarningSprite)
						Castle1princess.GetComponent<SpriteRenderer> ().sprite = princess2Sprite;
					else if (castlePrincessWarning == princess3WarningSprite)
						Castle1princess.GetComponent<SpriteRenderer> ().sprite = princess3Sprite;
				}
				if (castle2PrincessWarning.activeSelf) {
					Sprite castlePrincessWarning = castle2PrincessWarning.GetComponent<SpriteRenderer> ().sprite;
					castle2PrincessWarning.SetActive (false);
					Castle2princess.SetActive(true);
					if (castlePrincessWarning == princess1WarningSprite) {
						Debug.Log ("Princess 1");
						Castle2princess.GetComponent<SpriteRenderer> ().sprite = princess1Sprite;
					}
					else if (castlePrincessWarning == princess2WarningSprite){
						Debug.Log ("Princess 2");
						Castle2princess.GetComponent<SpriteRenderer> ().sprite = princess2Sprite;}
					else if (castlePrincessWarning == princess3WarningSprite){
						Debug.Log ("Princess 3");
						Castle2princess.GetComponent<SpriteRenderer>().sprite = princess3Sprite;}
				}
				if (castle3PrincessWarning.activeSelf) {
					Sprite castlePrincessWarning = castle3PrincessWarning.GetComponent<SpriteRenderer> ().sprite;
					castle3PrincessWarning.SetActive (false);
					Castle3princess.SetActive(true);
					if (castlePrincessWarning == princess1WarningSprite)
						Castle3princess.GetComponent<SpriteRenderer> ().sprite = princess1Sprite;
					else if (castlePrincessWarning == princess2WarningSprite)
						Castle3princess.GetComponent<SpriteRenderer> ().sprite = princess2Sprite;
					else if (castlePrincessWarning == princess3WarningSprite)
						Castle3princess.GetComponent<SpriteRenderer> ().sprite = princess3Sprite;
				}
				if (castle4PrincessWarning.activeSelf) {
					Sprite castlePrincessWarning = castle4PrincessWarning.GetComponent<SpriteRenderer> ().sprite;
					castle4PrincessWarning.SetActive (false);
					Castle4princess.SetActive(true);
					if (castlePrincessWarning == princess1WarningSprite)
						Castle4princess.GetComponent<SpriteRenderer> ().sprite = princess1Sprite;
					else if (castlePrincessWarning == princess2WarningSprite)
						Castle4princess.GetComponent<SpriteRenderer> ().sprite = princess2Sprite;
					else if (castlePrincessWarning == princess3WarningSprite)
						Castle4princess.GetComponent<SpriteRenderer> ().sprite = princess3Sprite;
				}
					

				// IMPLEMENT A RANDO PRINCESS WARNING IN A RANDOM CASTLE AS LONG AS THERE IS NOT PRINCESS THERE ALREADY

				randPrincess = Random.Range (1, 4);
				//Debug.Log (randPrincess);

				Sprite princessSprite = princess1WarningSprite;

				if (randPrincess == 1) {
					princessSprite = princess1WarningSprite;
				} else if (randPrincess == 2) {
					princessSprite = princess2WarningSprite;
				} else if (randPrincess == 3) {
					princessSprite = princess3WarningSprite;
				}

				randCastle = Random.Range (1, 5);

				if (randCastle == 1) {
					if (castle1PrincessWarning.activeSelf || Castle1princess.activeSelf) {
						randCastle = 2;
					} else {
						castle1PrincessWarning.SetActive (true);
						castle1PrincessWarning.GetComponent<SpriteRenderer> ().sprite = princessSprite;
						numPrincesses++;
					}
				}

				if (randCastle == 2) {
					if (castle2PrincessWarning.activeSelf || Castle2princess.activeSelf) {
						randCastle = 3;
					} else {
						castle2PrincessWarning.SetActive (true);
						castle2PrincessWarning.GetComponent<SpriteRenderer> ().sprite = princessSprite;
						numPrincesses++;
					}
				}

				if (randCastle == 3) {
					if (castle3PrincessWarning.activeSelf || Castle3princess.activeSelf) {
						randCastle = 4;
					} else {
						castle3PrincessWarning.SetActive (true);
						castle3PrincessWarning.GetComponent<SpriteRenderer> ().sprite = princessSprite;
						numPrincesses++;
					}
				}

				if (randCastle == 4) {
					if (castle4PrincessWarning.activeSelf || Castle4princess.activeSelf) {
						randCastle = 1;
					} else {
						castle4PrincessWarning.SetActive (true);
						castle4PrincessWarning.GetComponent<SpriteRenderer> ().sprite = princessSprite;
						numPrincesses++;
					}
				}
			}
		


			isPlayerTurn = true;


		}
		
	}
		
	public void endTurn()
	{
		isPlayerTurn = false;
	}


}
