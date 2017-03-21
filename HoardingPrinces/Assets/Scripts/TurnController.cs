using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TurnController : MonoBehaviour {

	public int isPlayerTurn = 0;
	// 0 = when players are allowed to move princes
	//1 = when the princesses are put on screen 
	//2 = when game displays text about what has happenened
	//3 = when character convos happen if they need to 
	public GameObject endTurnButton; 

	public bool isCutsceneGoingToPlay = false;
	public string princess1 = "princess1";
	public string princess2 = "princess2";
	public string princess3 = "princess3";

	public GameObject castle1;
	public GameObject castle2;
	public GameObject castle3; 
	public GameObject castle4; 

	public GameObject Prince1Location;
	public GameObject Prince2Location;
	public GameObject Prince3Location;

	public string PrincessInCastle1;
	public string PrincessInCastle2;
	public string PrincessInCastle3;
	public string PrincessInCastle4;


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

	public bool princess1OnMap = false;
	public bool princess2OnMap = false;
	public bool princess3OnMap = false;


	public int randPrincess;
	public int randCastle;

	public bool hasNoNewPrincess;
	public bool princessInCastle;

	public bool princessInCastle1;
	public bool princessInCastle2;
	public bool princessInCastle3;
	public bool princessInCastle4;

	public bool princess1InCastle;
	public bool princess2InCastle;
	public bool princess3InCastle;

	public bool princess1InCastle1WithPrince1;
	public bool princess1InCastle2WithPrince1;
	public bool princess1InCastle3WithPrince1;
	public bool princess1InCastle4WithPrince1;

	public bool princess2InCastle1WithPrince1;
	public bool princess2InCastle2WithPrince1;
	public bool princess2InCastle3WithPrince1;
	public bool princess2InCastle4WithPrince1;

	public bool princess3InCastle1WithPrince1;
	public bool princess3InCastle2WithPrince1;
	public bool princess3InCastle3WithPrince1;
	public bool princess3InCastle4WithPrince1;


	public bool princess1InCastle1WithPrince2;
	public bool princess1InCastle2WithPrince2;
	public bool princess1InCastle3WithPrince2;
	public bool princess1InCastle4WithPrince2;

	public bool princess2InCastle1WithPrince2;
	public bool princess2InCastle2WithPrince2;
	public bool princess2InCastle3WithPrince2;
	public bool princess2InCastle4WithPrince2;

	public bool princess3InCastle1WithPrince2;
	public bool princess3InCastle2WithPrince2;
	public bool princess3InCastle3WithPrince2;
	public bool princess3InCastle4WithPrince2;


	public bool princess1InCastle1WithPrince3;
	public bool princess1InCastle2WithPrince3;
	public bool princess1InCastle3WithPrince3;
	public bool princess1InCastle4WithPrince3;

	public bool princess2InCastle1WithPrince3;
	public bool princess2InCastle2WithPrince3;
	public bool princess2InCastle3WithPrince3;
	public bool princess2InCastle4WithPrince3;

	public bool princess3InCastle1WithPrince3;
	public bool princess3InCastle2WithPrince3;
	public bool princess3InCastle3WithPrince3;
	public bool princess3InCastle4WithPrince3;


	public int numPrincesses = 0 ;


	public GameObject endTurnQuestion;
	public Text endTurnQuestionText;




	// Use this for initialization
	void Start () {
		prince1 =  GameObject.Find ("Prince1");
		prince2 =  GameObject.Find ("Prince2");
		prince3 =  GameObject.Find ("Prince3");

	}
	
	// Update is called once per frame
	void Update () {

		updateVariables ();
		getRidOfEndTurnButton ();
	

		if (isPlayerTurn == 1) {

			princess1InCastle = false;
			princess2InCastle = false;
			princess3InCastle = false;


			//Check if there is any princess currently on the map. If yes, have princess leave the screen

		
			if (Castle1princess.activeSelf) {
				Castle1princess.SetActive (false);
				numPrincesses--;
				princessInCastle1 = false;
			}
			if (Castle2princess.activeSelf) {
				Castle2princess.SetActive (false);
				numPrincesses--;
				princessInCastle2 = false;
			}
			if (Castle3princess.activeSelf) {
				Castle3princess.SetActive (false);
				numPrincesses--;
				princessInCastle3 = false;
			}
			if (Castle4princess.activeSelf) {
				Castle4princess.SetActive (false);
				numPrincesses--;
				princessInCastle4 = false;
			}


			//If there are no more than 2 princesses on screen + about to be on screen
	
			if (numPrincesses < 2) {

				//princessInCastle = true;

				//CHECK TO SEE IF THERE IS A PRINCESS WARNING ON EACH CASTLE AND IF YES, HAVE PRINCESS VISIT THE CASTLE

				if (castle1PrincessWarning.activeSelf) {
					princessInCastle1 = true;
					Sprite castlePrincessWarning = castle1PrincessWarning.GetComponent<SpriteRenderer> ().sprite;
					castle1PrincessWarning.SetActive (false);
					Castle1princess.SetActive(true);
					if (castlePrincessWarning == princess1WarningSprite) {
						Castle1princess.GetComponent<SpriteRenderer> ().sprite = princess1Sprite;
						princess1InCastle = true;
					} 
					else if (castlePrincessWarning == princess2WarningSprite) {
						Castle1princess.GetComponent<SpriteRenderer> ().sprite = princess2Sprite;
						princess2InCastle = true;
					} 
					else if (castlePrincessWarning == princess3WarningSprite) {
						Castle1princess.GetComponent<SpriteRenderer> ().sprite = princess3Sprite;
						princess3InCastle = true;
					}
				}
				if (castle2PrincessWarning.activeSelf) {
					princessInCastle2 = true;
					Sprite castlePrincessWarning = castle2PrincessWarning.GetComponent<SpriteRenderer> ().sprite;
					castle2PrincessWarning.SetActive (false);
					Castle2princess.SetActive(true);
					if (castlePrincessWarning == princess1WarningSprite) {
						//Debug.Log ("Princess 1");
						Castle2princess.GetComponent<SpriteRenderer> ().sprite = princess1Sprite;
						princess1InCastle = true;
					} else if (castlePrincessWarning == princess2WarningSprite) {
						//Debug.Log ("Princess 2");
						Castle2princess.GetComponent<SpriteRenderer> ().sprite = princess2Sprite;
						princess2InCastle = true;
					} else if (castlePrincessWarning == princess3WarningSprite) {
						//Debug.Log ("Princess 3");
						Castle2princess.GetComponent<SpriteRenderer> ().sprite = princess3Sprite;
						princess3InCastle = true;
					}
				}
				if (castle3PrincessWarning.activeSelf) {
					princessInCastle3 = true;
					Sprite castlePrincessWarning = castle3PrincessWarning.GetComponent<SpriteRenderer> ().sprite;
					castle3PrincessWarning.SetActive (false);
					Castle3princess.SetActive(true);
					if (castlePrincessWarning == princess1WarningSprite) {
						Castle3princess.GetComponent<SpriteRenderer> ().sprite = princess1Sprite;
						princess1InCastle = true;
					} else if (castlePrincessWarning == princess2WarningSprite) {
						Castle3princess.GetComponent<SpriteRenderer> ().sprite = princess2Sprite;
						princess2InCastle = true;
					} else if (castlePrincessWarning == princess3WarningSprite) {
						Castle3princess.GetComponent<SpriteRenderer> ().sprite = princess3Sprite;
						princess3InCastle = true;
					}
				}
				if (castle4PrincessWarning.activeSelf) {
					princessInCastle4 = true;
					Sprite castlePrincessWarning = castle4PrincessWarning.GetComponent<SpriteRenderer> ().sprite;
					castle4PrincessWarning.SetActive (false);
					Castle4princess.SetActive(true);

					if (castlePrincessWarning == princess1WarningSprite) {
						Castle4princess.GetComponent<SpriteRenderer> ().sprite = princess1Sprite;
						princess1InCastle = true;
					} 
					else if (castlePrincessWarning == princess2WarningSprite) {
						Castle4princess.GetComponent<SpriteRenderer> ().sprite = princess2Sprite;
						princess2InCastle = true;
					} 
					else if (castlePrincessWarning == princess3WarningSprite) {
						Castle4princess.GetComponent<SpriteRenderer> ().sprite = princess3Sprite;
						princess3InCastle = true;
					}
				}
					

				// IMPLEMENT A RANDO PRINCESS WARNING IN A RANDOM CASTLE AS LONG AS THERE IS NOT PRINCESS THERE ALREADY

				randPrincess = Random.Range (1,8);
				//Debug.Log (randPrincess);

				Sprite princessSprite = null;

				if (randPrincess == 1 && princess1OnMap== false) {
					princessSprite = princess1WarningSprite;
				} else if (randPrincess == 2 && princess2OnMap== false) {
					princessSprite = princess2WarningSprite;
				} else if (randPrincess == 3 && princess3OnMap== false) {
					princessSprite = princess3WarningSprite;
				}

				//Debug.Log (princessSprite);

				randCastle = Random.Range (1, 5);

				if (princessSprite != null) {

					hasNoNewPrincess = false;


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

				else {
					hasNoNewPrincess = true;
				}
			}
		



			if (princess1OnMap == false) {
				princess1InCastle = false;
			}

			if (princess2OnMap == false) {
				princess2InCastle = false;
			}

			if (princess3OnMap == false) {
				princess3InCastle = false;
			}

			if (princessInCastle1 || princessInCastle2 || princessInCastle3 || princessInCastle4)
				princessInCastle = true;
			else
				princessInCastle = false;
			
			isPlayerTurn = 2;




		}

		if (isPlayerTurn == 2) {

			EndTurnText ();


		}



		if (isPlayerTurn == 3) {
			
			endTurnQuestionText.text = "";
			endTurnQuestion.SetActive (false);
			//isPlayerTurn = 0;
		}
		
	}
		
	public void endTurn()
	{
		if (isPlayerTurn == 0)
			isPlayerTurn = 1;
	}

	public void endTextTurn()
	{
		/*if (isPlayerTurn != 0 && isCutsceneGoingToPlay == false) {
			isPlayerTurn = 0;
			endTurnQuestionText.text = "";
			endTurnQuestion.SetActive (false);
		} else if (isPlayerTurn != 0 && isCutsceneGoingToPlay) {
			isPlayerTurn = 3;
		} else {
			isPlayerTurn = 0;
			endTurnQuestionText.text = "";
			endTurnQuestion.SetActive (false);
		}*/

		isPlayerTurn = 3;
		endTurnQuestionText.text = "";
		endTurnQuestion.SetActive (false);

		//Debug.Log (isPlayerTurn);
	}




	public void checkIfPrincessInCastle()
	{

	
/*
		if (princessInCastle) {
			if (princessInCastle1) {
				if (Prince1Location == castle1 && )
					

			}


		}   

*/

	}

	public void updateVariables()
	{

		Prince1Location = GameObject.Find ("GameManager").GetComponent<PrinceManager>().Prince1_Location;
		Prince2Location = GameObject.Find ("GameManager").GetComponent<PrinceManager>().Prince2_Location;
		Prince3Location = GameObject.Find ("GameManager").GetComponent<PrinceManager>().Prince3_Location;

		princess1OnMap = GetComponent<PrincessScrpt>().princess1OnMap;
		princess2OnMap = GetComponent<PrincessScrpt>().princess2OnMap;
		princess3OnMap = GetComponent<PrincessScrpt>().princess3OnMap;


		princess1InCastle1WithPrince1 = false;
		princess1InCastle2WithPrince1 = false;
		princess1InCastle3WithPrince1 = false;
		princess1InCastle4WithPrince1 = false;

		princess2InCastle1WithPrince1 = false;
		princess2InCastle2WithPrince1 = false;
		princess2InCastle3WithPrince1 = false;
		princess2InCastle4WithPrince1 = false;

		princess3InCastle1WithPrince1 = false;
		princess3InCastle2WithPrince1 = false;
		princess3InCastle3WithPrince1 = false;
		princess3InCastle4WithPrince1 = false;


		princess1InCastle1WithPrince2 = false;
		princess1InCastle2WithPrince2 = false;
		princess1InCastle3WithPrince2 = false;
		princess1InCastle4WithPrince2 = false;

		princess2InCastle1WithPrince2 = false;
		princess2InCastle2WithPrince2 = false;
		princess2InCastle3WithPrince2 = false;
		princess2InCastle4WithPrince2 = false;

		princess3InCastle1WithPrince2 = false;
		princess3InCastle2WithPrince2 = false;
		princess3InCastle3WithPrince2 = false;
		princess3InCastle4WithPrince2 = false;


		princess1InCastle1WithPrince3 = false;
		princess1InCastle2WithPrince3 = false;
		princess1InCastle3WithPrince3 = false;
		princess1InCastle4WithPrince3 = false;

		princess2InCastle1WithPrince3 = false;
		princess2InCastle2WithPrince3 = false;
		princess2InCastle3WithPrince3 = false;
		princess2InCastle4WithPrince3 = false;

		princess3InCastle1WithPrince3 = false;
		princess3InCastle2WithPrince3 = false;
		princess3InCastle3WithPrince3 = false;
		princess3InCastle4WithPrince3 = false;

		Sprite Castle1PrincessSprite;
		if (Castle1princess.activeSelf) {
			Castle1PrincessSprite = Castle1princess.GetComponent<SpriteRenderer> ().sprite;
			if (Castle1PrincessSprite == princess1Sprite)
				PrincessInCastle1 = princess1;
			else if (Castle1PrincessSprite == princess2Sprite)
				PrincessInCastle1 = princess2;
			else if (Castle1PrincessSprite == princess3Sprite)
				PrincessInCastle1 = princess3;


			if (PrincessInCastle1 == princess1) {
				if (Prince1Location == castle1)
					princess1InCastle1WithPrince1 = true;
				else if (Prince2Location == castle1)
					princess1InCastle1WithPrince2 = true;
				else if (Prince3Location == castle1)
					princess1InCastle1WithPrince3 = true;
			}
			else if (PrincessInCastle1 == princess2) {
				if (Prince1Location == castle1)
					princess2InCastle1WithPrince1 = true;
				else if (Prince2Location == castle1)
					princess2InCastle1WithPrince2 = true;
				else if (Prince3Location == castle1)
					princess2InCastle1WithPrince3 = true;
			}
			else if (PrincessInCastle1 == princess3) {
				if (Prince1Location == castle1)
					princess3InCastle1WithPrince1 = true;
				else if (Prince2Location == castle1)
					princess3InCastle1WithPrince2 = true;
				else if (Prince3Location == castle1)
					princess3InCastle1WithPrince3 = true;
			}
		}
		
		Sprite Castle2PrincessSprite;
		if (Castle2princess.activeSelf) {
			Castle2PrincessSprite = Castle2princess.GetComponent<SpriteRenderer> ().sprite;
			if (Castle2PrincessSprite == princess1Sprite)
				PrincessInCastle2 = princess1;
			else if (Castle2PrincessSprite == princess2Sprite)
				PrincessInCastle2 = princess2;
			else if (Castle2PrincessSprite == princess3Sprite)
				PrincessInCastle2 = princess3;

			if (PrincessInCastle2 == princess1) {
				if (Prince1Location == castle2)
					princess1InCastle2WithPrince1 = true;
				else if (Prince2Location == castle2)
					princess1InCastle2WithPrince2 = true;
				else if (Prince3Location == castle2)
					princess1InCastle2WithPrince3 = true;
			}
			else if (PrincessInCastle2 == princess2) {
				if (Prince1Location == castle2)
					princess2InCastle2WithPrince1 = true;
				else if (Prince2Location == castle2)
					princess2InCastle2WithPrince2 = true;
				else if (Prince3Location == castle2)
					princess2InCastle2WithPrince3 = true;
			}
			else if (PrincessInCastle2 == princess3) {
				if (Prince1Location == castle2)
					princess3InCastle2WithPrince1 = true;
				else if (Prince2Location == castle2)
					princess3InCastle2WithPrince2 = true;
				else if (Prince3Location == castle2)
					princess3InCastle2WithPrince3 = true;
			}
		}
		
		Sprite Castle3PrincessSprite;
		if (Castle3princess.activeSelf) {
			Castle3PrincessSprite = Castle3princess.GetComponent<SpriteRenderer> ().sprite;
			if (Castle3PrincessSprite == princess1Sprite)
				PrincessInCastle3 = princess1;
			else if (Castle3PrincessSprite == princess2Sprite)
				PrincessInCastle3 = princess2;
			else if (Castle3PrincessSprite == princess3Sprite)
				PrincessInCastle3 = princess3;


			if (PrincessInCastle3 == princess1) {
				if (Prince1Location == castle3)
					princess1InCastle3WithPrince1 = true;
				else if (Prince2Location == castle3)
					princess1InCastle3WithPrince2 = true;
				else if (Prince3Location == castle3)
					princess1InCastle3WithPrince3 = true;
			}
			else if (PrincessInCastle3 == princess2) {
				if (Prince1Location == castle3)
					princess2InCastle3WithPrince1 = true;
				else if (Prince2Location == castle3)
					princess2InCastle3WithPrince2 = true;
				else if (Prince3Location == castle3)
					princess2InCastle3WithPrince3 = true;
			}
			else if (PrincessInCastle3 == princess3) {
				if (Prince1Location == castle3)
					princess3InCastle3WithPrince1 = true;
				else if (Prince2Location == castle3)
					princess3InCastle3WithPrince2 = true;
				else if (Prince3Location == castle3)
					princess3InCastle3WithPrince3 = true;
			}
		}
		Sprite Castle4PrincessSprite;
		if (Castle4princess.activeSelf) {
			Castle4PrincessSprite = Castle4princess.GetComponent<SpriteRenderer> ().sprite;
			if (Castle4PrincessSprite == princess1Sprite)
				PrincessInCastle4 = princess1;
			else if (Castle4PrincessSprite == princess2Sprite)
				PrincessInCastle4 = princess2;
			else if (Castle4PrincessSprite == princess3Sprite)
				PrincessInCastle4 = princess3;


			if (PrincessInCastle4 == princess1) {
				if (Prince1Location == castle4)
					princess1InCastle4WithPrince1 = true;
				else if (Prince2Location == castle4)
					princess1InCastle4WithPrince2 = true;
				else if (Prince3Location == castle4)
					princess1InCastle4WithPrince3 = true;
			}
			else if (PrincessInCastle4 == princess2) {
				if (Prince1Location == castle4)
					princess2InCastle4WithPrince1 = true;
				else if (Prince2Location == castle4)
					princess2InCastle4WithPrince2 = true;
				else if (Prince3Location == castle4)
					princess2InCastle4WithPrince3 = true;
			}
			else if (PrincessInCastle4 == princess3) {
				if (Prince1Location == castle4)
					princess3InCastle4WithPrince1 = true;
				else if (Prince2Location == castle4)
					princess3InCastle4WithPrince2 = true;
				else if (Prince3Location == castle4)
					princess3InCastle4WithPrince3 = true;
			}
		}
	
	}


	public void getRidOfEndTurnButton()
	{
		if (isPlayerTurn != 0) {
			endTurnButton.SetActive (false);
		}
		if (isPlayerTurn == 0) {
			endTurnButton.SetActive (true);
			//Debug.Log("test");
		}
	}


	public void EndTurnText()
	{

		isCutsceneGoingToPlay = false;

		if (princessInCastle) {
			//Text endQuestionText; 
			//Text Princess;
			//Text Prince;
			endTurnQuestionText.text = "Princess has reached an empty castle!";

			if (princess1InCastle1WithPrince1 || princess1InCastle2WithPrince1 || princess1InCastle3WithPrince1 || princess1InCastle4WithPrince1) {
				endTurnQuestionText.text = "Princess Thyme has reached Prince Chris!";
				endTurnQuestion.SetActive (true);
				isCutsceneGoingToPlay = true;
			} else if (princess2InCastle1WithPrince1 || princess2InCastle2WithPrince1 || princess2InCastle3WithPrince1 || princess2InCastle4WithPrince1) {
				endTurnQuestionText.text = "Princess Matcha has reached Prince Chris!";
				endTurnQuestion.SetActive (true);
			} else if (princess3InCastle1WithPrince1 || princess3InCastle2WithPrince1 || princess3InCastle3WithPrince1 || princess3InCastle4WithPrince1) {
				endTurnQuestionText.text = "Princess Pepper has reached Prince Chris!";
				endTurnQuestion.SetActive (true);
				isCutsceneGoingToPlay = true;
			} else if (princess1InCastle1WithPrince2 || princess1InCastle2WithPrince2 || princess1InCastle3WithPrince2 || princess1InCastle4WithPrince2) {
				endTurnQuestionText.text = "Princess Thyme has reached Prince Chris!";
				endTurnQuestion.SetActive (true);
				isCutsceneGoingToPlay = true;
			} else if (princess2InCastle1WithPrince2 || princess2InCastle2WithPrince2 || princess2InCastle3WithPrince2 || princess2InCastle4WithPrince2) {
				endTurnQuestionText.text = "Princess Matcha has reached Prince Chris!";
				endTurnQuestion.SetActive (true);
				isCutsceneGoingToPlay = true;
			} else if (princess3InCastle1WithPrince2 || princess3InCastle2WithPrince2 || princess3InCastle3WithPrince2 || princess3InCastle4WithPrince2) {
				endTurnQuestionText.text = "Princess Pepper has reached Prince Chris!";
				endTurnQuestion.SetActive (true);
				isCutsceneGoingToPlay = true;
			} else if (princess1InCastle1WithPrince3 || princess1InCastle2WithPrince3 || princess1InCastle3WithPrince3 || princess1InCastle4WithPrince3) {
				endTurnQuestionText.text = "Princess Thyme has reached Prince Thistle!";
				endTurnQuestion.SetActive (true);
				isCutsceneGoingToPlay = true;
			} else if (princess2InCastle1WithPrince3 || princess2InCastle2WithPrince3 || princess2InCastle3WithPrince3 || princess2InCastle4WithPrince3) {
				endTurnQuestionText.text = "Princess Matcha has reached Prince Thistle!";
				endTurnQuestion.SetActive (true);
				isCutsceneGoingToPlay = true;
			} else if (princess3InCastle1WithPrince3 || princess3InCastle2WithPrince3 || princess3InCastle3WithPrince3 || princess3InCastle4WithPrince3) {
				endTurnQuestionText.text = "Princess Pepper has reached Prince Thistle!";
				endTurnQuestion.SetActive (true);
				isCutsceneGoingToPlay = true;
			}

			endTurnQuestion.SetActive (true);




		} else if (hasNoNewPrincess) {
			endTurnQuestionText.text = "Nothing suspicious just yet....";
			endTurnQuestion.SetActive (true);
		} else {
			//Text endQuestionText; 
			//Text Princess;
			//Text Prince;
			endTurnQuestionText.text = "Some suspicious activity seems to be about!";
			endTurnQuestion.SetActive (true);
		}
	}
}
