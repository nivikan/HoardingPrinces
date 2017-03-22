using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class dialogueSystem : MonoBehaviour {


	//each set of convos will be in 1 txt file. for example, all of Thyme and Darjeeling's 
	//conversations willbe in 1 fil

	//Each line will be 'character initial:mood:dialogue
	//example: D:angry:Get the hell out of my castle!

	//Return after every new speach bubble
	// EX:
	//D:angry:Get the hell out of my castle!
	//D:normal:I mean...Leave.
	//Tm:normal:...meh

	//RETURN + '/' + RETURN after every convo (so next convo happens next time the characters meet.

	public GameObject GameManager;
	public int numInConvo;

	public Sprite currPrinceSprite;
	public Sprite currPrincessSprite;

	public Text theText;
	public Text personSpeaking;
	public GameObject frontTalkPanel;
	public GameObject talkingPrincess;
	public GameObject talkingPrince;
	//public GameObject Prince_Mouth;
	//spublic GameObject Princess_Mouth;

	public bool DarjeelingStillOnMap = true;
	public bool ChrisStillOnMap = true;
	public bool ThistleStillOnMap = true;
	public bool ThymeStillOnMap = true;
	public bool MatchaStillOnMap = true;
	public bool PepperStillOnMap = true;


	public TextAsset DarjeelingAndThyme;
	public int DarjeelingAndThymeEncounter = 0;
	public string[] DarjeelingAndThymeConvo0;
	public string[] DarjeelingAndThymeConvo1;
	public string[] DarjeelingAndThymeConvo2;
	public string[] DarjeelingAndThymeConvo3;

	public TextAsset DarjeelingAndMatcha;
	public int DarjeelingAndMatchaEncounter = 0;
	public string[] DarjeelingAndMatchaConvo0;
	public string[] DarjeelingAndMatchaConvo1;
	public string[] DarjeelingAndMatchaConvo2;
	public string[] DarjeelingAndMatchaConvo3;

	public TextAsset DarjeelingAndPepper;
	public int DarjeelingAndPepperEncounter = 0;
	public string[] DarjeelingAndPepperConvo0;
	public string[] DarjeelingAndPepperConvo1;
	public string[] DarjeelingAndPepperConvo2;
	public string[] DarjeelingAndPepperConvo3;



	public TextAsset ChrisAndThyme;
	public int ChrisAndThymeEncounter = 0;
	public string[] ChrisAndThymeConvo0;
	public string[] ChrisAndThymeConvo1;
	public string[] ChrisAndThymeConvo2;
	public string[] ChrisAndThymeConvo3;

	public TextAsset ChrisAndMatcha;
	public int ChrisAndMatchaEncounter = 0;
	public string[] ChrisAndMatchaConvo0;
	public string[] ChrisAndMatchaConvo1;
	public string[] ChrisAndMatchaConvo2;
	public string[] ChrisAndMatchaConvo3;

	public TextAsset ChrisAndPepper;
	public int ChrisAndPepperEncounter = 0;
	public string[] ChrisAndPepperConvo0;
	public string[] ChrisAndPepperConvo1;
	public string[] ChrisAndPepperConvo2;
	public string[] ChrisAndPepperConvo3;


	public TextAsset ThistleAndThyme;
	public int ThistleAndThymeEncounter = 0;
	public string[] ThistleAndThymeConvo0;
	public string[] ThistleAndThymeConvo1;
	public string[] ThistleAndThymeConvo2;
	public string[] ThistleAndThymeConvo3;

	public TextAsset ThistleAndMatcha;
	public int ThistleAndMatchaEncounter = 0;
	public string[] ThistleAndMatchaConvo0;
	public string[] ThistleAndMatchaConvo1;
	public string[] ThistleAndMatchaConvo2;
	public string[] ThistleAndMatchaConvo3;

	public TextAsset ThistleAndPepper;
	public int ThistleAndPepperEncounter = 0;
	public string[] ThistleAndPepperConvo0;
	public string[] ThistleAndPepperConvo1;
	public string[] ThistleAndPepperConvo2;
	public string[] ThistleAndPepperConvo3;


	//ALL CHARACTER SPRITES
	//import as Textures
	public Sprite DarjeelingNormal;
	public Sprite DarjeelingHappy;
	public Sprite DarjeelingSad;
	public Sprite DarjeelingAngry;
	public Sprite DarjeelingExcited;
	public Sprite DarjeelingDissappointed;
	public Sprite DarjeelingBlush;

	public Sprite ChrisNormal;
	public Sprite ChrisHappy;
	public Sprite ChrisSad;
	public Sprite ChrisAngry;
	public Sprite ChrisExcited;
	public Sprite ChrisDissappointed;
	public Sprite ChrisBlush;

	public Sprite ThymeNormal;
	public Sprite ThymeHappy;
	public Sprite ThymeSad;
	public Sprite ThymeAngry;
	public Sprite ThymeExcited;
	public Sprite ThymeDissappointed;
	public Sprite ThymeBlush;


	public Sprite ThistleNormal;
	public Sprite ThistleHappy;
	public Sprite ThistleSad;
	public Sprite ThistleAngry;
	public Sprite ThistleExcited;
	public Sprite ThistleDissappointed;
	public Sprite ThistleBlush;

	public Sprite MatchaNormal;
	public Sprite MatchaHappy;
	public Sprite MatchaSad;
	public Sprite MatchaAngry;
	public Sprite MatchaExcited;
	public Sprite MatchaDissappointed;
	public Sprite MatchaBlush;

	public Sprite PepperNormal;
	public Sprite PepperHappy;
	public Sprite PepperSad;
	public Sprite PepperAngry;
	public Sprite PepperExcited;
	public Sprite PepperDissappointed;
	public Sprite PepperBlush;


	public bool DarjeelingAndThymeMeet = false;
	public bool DarjeelingAndMatchaMeet = false;
	public bool DarjeelingAndPepperMeet = false;

	public bool ChrisAndThymeMeet = false;
	public bool ChrisAndMatchaMeet = false;
	public bool ChrisAndPepperMeet = false;

	public bool ThistleAndThymeMeet = false;
	public bool ThistleAndMatchaMeet = false;
	public bool ThistleAndPepperMeet = false;



	// Use this for initialization
	void Start () {


		//Prince Darjeeling
		if (DarjeelingAndThyme != null) {
			string[] AllConvos = (DarjeelingAndThyme.text.Split ('/'));
			DarjeelingAndThymeConvo0 = getRidOfBlankArray (AllConvos[0].Split ('\n'));
			printStringArray (DarjeelingAndThymeConvo0);
			//printStringArray(DarjeelingAndThymeConvo0);
			//DarjeelingAndThymeConvo0 = getRidOfBlankArray (DarjeelingAndThymeConvo0);

			DarjeelingAndThymeConvo1 = getRidOfBlankArray(AllConvos[1].Split ('\n'));
			printStringArray (DarjeelingAndThymeConvo1);
			//printStringArray(DarjeelingAndThymeConvo1);
			//DarjeelingAndThymeConvo1 = getRidOfBlankArray (DarjeelingAndThymeConvo1);

			DarjeelingAndThymeConvo2 = getRidOfBlankArray(AllConvos[2].Split ('\n'));
			printStringArray (DarjeelingAndThymeConvo2);
			//printStringArray(DarjeelingAndThymeConvo2);
			//DarjeelingAndThymeConvo2 = getRidOfBlankArray (DarjeelingAndThymeConvo2);

			DarjeelingAndThymeConvo3 = getRidOfBlankArray(AllConvos[3].Split ('\n'));
			printStringArray (DarjeelingAndThymeConvo3);
			//printStringArray(DarjeelingAndThymeConvo3);
			//DarjeelingAndThymeConvo3 = getRidOfBlankArray (DarjeelingAndThymeConvo3);

		}
		if (DarjeelingAndMatcha != null) {
			string[] AllConvos = (DarjeelingAndMatcha.text.Split ('/'));
			DarjeelingAndMatchaConvo0 = getRidOfBlankArray(AllConvos[0].Split ('\n'));
			DarjeelingAndMatchaConvo1 = getRidOfBlankArray(AllConvos[1].Split ('\n'));
			DarjeelingAndMatchaConvo2 = getRidOfBlankArray(AllConvos[2].Split ('\n'));
			DarjeelingAndMatchaConvo3 = getRidOfBlankArray(AllConvos[3].Split ('\n'));
		}
		if (DarjeelingAndPepper != null) {
			string[] AllConvos = (DarjeelingAndPepper.text.Split ('/'));
			DarjeelingAndPepperConvo0 = getRidOfBlankArray(AllConvos[0].Split ('\n'));
			DarjeelingAndPepperConvo1 = getRidOfBlankArray(AllConvos[1].Split ('\n'));
			DarjeelingAndPepperConvo2 = getRidOfBlankArray(AllConvos[2].Split ('\n'));
			DarjeelingAndPepperConvo3 = getRidOfBlankArray(AllConvos[3].Split ('\n'));
		}



		//Prince Chris
		if (ChrisAndThyme != null) {
			string[] AllConvos = (ChrisAndThyme.text.Split ('/'));
			ChrisAndThymeConvo0 = getRidOfBlankArray(AllConvos[0].Split ('\n'));
			ChrisAndThymeConvo1 = getRidOfBlankArray(AllConvos[1].Split ('\n'));
			ChrisAndThymeConvo2 = getRidOfBlankArray(AllConvos[2].Split ('\n'));
			ChrisAndThymeConvo3 = getRidOfBlankArray(AllConvos[3].Split ('\n'));
		}
		if (ChrisAndMatcha != null) {
			string[] AllConvos = (ChrisAndMatcha.text.Split ('/'));
			ChrisAndMatchaConvo0 = getRidOfBlankArray(AllConvos[0].Split ('\n'));
			ChrisAndMatchaConvo1 = getRidOfBlankArray(AllConvos[1].Split ('\n'));
			ChrisAndMatchaConvo2 = getRidOfBlankArray(AllConvos[2].Split ('\n'));
			ChrisAndMatchaConvo3 = getRidOfBlankArray(AllConvos[3].Split ('\n'));
		}
		if (ChrisAndPepper != null) {
			string[] AllConvos = (ChrisAndPepper.text.Split ('/'));
			ChrisAndPepperConvo0 = getRidOfBlankArray(AllConvos[0].Split ('\n'));
			ChrisAndPepperConvo1 = getRidOfBlankArray(AllConvos[1].Split ('\n'));
			ChrisAndPepperConvo2 = getRidOfBlankArray(AllConvos[2].Split ('\n'));
			ChrisAndPepperConvo3 = getRidOfBlankArray(AllConvos[3].Split ('\n'));
		}



		//Prince Thistle
		if (ThistleAndThyme != null) {
			string[] AllConvos = (ThistleAndThyme.text.Split ('/'));
			ThistleAndThymeConvo0 = getRidOfBlankArray(AllConvos[0].Split ('\n'));
			ThistleAndThymeConvo1 = getRidOfBlankArray(AllConvos[1].Split ('\n'));
			ThistleAndThymeConvo2 = getRidOfBlankArray(AllConvos[2].Split ('\n'));
			ThistleAndThymeConvo3 = getRidOfBlankArray(AllConvos[3].Split ('\n'));
		}
		if (ThistleAndMatcha != null) {
			string[] AllConvos = (ThistleAndMatcha.text.Split ('/'));
			ThistleAndMatchaConvo0 = getRidOfBlankArray(AllConvos[0].Split ('\n'));
			ThistleAndMatchaConvo1 = getRidOfBlankArray(AllConvos[1].Split ('\n'));
			ThistleAndMatchaConvo2 = getRidOfBlankArray(AllConvos[2].Split ('\n'));
			ThistleAndMatchaConvo3 = getRidOfBlankArray(AllConvos[3].Split ('\n'));
		}
		if (ThistleAndPepper != null) {
			string[] AllConvos = (ThistleAndPepper.text.Split ('/'));
			ThistleAndPepperConvo0 = getRidOfBlankArray(AllConvos[0].Split ('\n'));
			ThistleAndPepperConvo1 = getRidOfBlankArray(AllConvos[1].Split ('\n'));
			ThistleAndPepperConvo2 = getRidOfBlankArray(AllConvos[2].Split ('\n'));
			ThistleAndPepperConvo3 = getRidOfBlankArray(AllConvos[3].Split ('\n'));
		}





		
	}
	
	// Update is called once per frame
	void Update () {


		if (GameManager.GetComponent<TurnController> ().isPlayerTurn == 3) {

			updateMeetingVariables ();

			//Debug.Log ("isPlayerTurn is 3!");

			/*
			Debug.Log (DarjeelingAndThymeMeet);
			Debug.Log (DarjeelingAndMatchaMeet);
			Debug.Log (DarjeelingAndPepperMeet);

			Debug.Log (ChrisAndThymeMeet);
			Debug.Log (ChrisAndMatchaMeet);
			Debug.Log (ChrisAndPepperMeet);

			Debug.Log (ThistleAndThymeMeet);
			Debug.Log (ThistleAndMatchaMeet);
			Debug.Log (ThistleAndPepperMeet);
			*/

			//DARJEELING
			if (DarjeelingAndThymeMeet) {
				currPrinceSprite = getSprite("Darjeeling","normal");
				currPrincessSprite = getSprite("Thyme","normal");

				talkingPrince.GetComponent<Image>().sprite = currPrinceSprite;
				talkingPrincess.GetComponent<Image>().sprite = currPrincessSprite;

				makeDarjeelingThymeConvo ();
			}

			else if (DarjeelingAndMatchaMeet) {
				currPrinceSprite = getSprite("Darjeeling","normal");
				currPrincessSprite = getSprite("Matcha","normal");
				makeDarjeelingMatchaConvo ();
			}

			else if (DarjeelingAndPepperMeet) {
				currPrinceSprite = getSprite("Darjeeling","normal");
				currPrincessSprite = getSprite("Pepper","normal");
				makeDarjeelingPepperConvo ();
			}
		
			//CHRIS
			else if (ChrisAndThymeMeet) {
				currPrinceSprite = getSprite("Chris","normal");
				currPrincessSprite = getSprite("Thyme","normal");
				makeChrisThymeConvo ();
			}

			else if (ChrisAndMatchaMeet) {
				currPrinceSprite = getSprite("Chris","normal");
				currPrincessSprite = getSprite("Matcha","normal");
				makeChrisMatchaConvo ();
			}

			else if (ChrisAndPepperMeet) {
				currPrinceSprite = getSprite("Chris","normal");
				currPrincessSprite = getSprite("Pepper","normal");
				makeChrisPepperConvo ();
			}

			//Thistle
			else if (ThistleAndThymeMeet) {
				currPrinceSprite = getSprite("Thistle","normal");
				currPrincessSprite = getSprite("Thyme","normal");
				makeThistleThymeConvo ();
			}

			else if (ThistleAndMatchaMeet) {
				currPrinceSprite = getSprite("Thistle","normal");
				currPrincessSprite = getSprite("Matcha","normal");
				makeThistleMatchaConvo ();
			}

			else if (ThistleAndPepperMeet) {
				currPrinceSprite = getSprite("Thistle","normal");
				currPrincessSprite = getSprite("Pepper","normal");
				makeThistlePepperConvo ();
			}
			else{
				Debug.Log ("No Convo");
				GameManager.GetComponent<TurnController> ().isPlayerTurn = 0;
				}


		}
			

	}






	void makeDarjeelingThymeConvo()
	{
		if (DarjeelingAndThymeEncounter == 0) {
			print (numInConvo);
			if (numInConvo >= DarjeelingAndThymeConvo0.Length)
				endDialogueTurn ();
			else
				makeConvo (DarjeelingAndThymeConvo0[numInConvo]);
		}

		else if (DarjeelingAndThymeEncounter == 1) {
			if (numInConvo >= DarjeelingAndThymeConvo1.Length)
				endDialogueTurn ();
			else
				makeConvo (DarjeelingAndThymeConvo1[numInConvo]);
		}
		else if (DarjeelingAndThymeEncounter == 2) {
			if (numInConvo >= DarjeelingAndThymeConvo2.Length)
				endDialogueTurn ();
			else
				makeConvo (DarjeelingAndThymeConvo2[numInConvo]);
			
		}
		else if (DarjeelingAndThymeEncounter == 3) {
			if (numInConvo >= DarjeelingAndThymeConvo3.Length)
				endDialogueTurn ();
			else
				makeConvo (DarjeelingAndThymeConvo3[numInConvo]);
			DarjeelingAndThymeEncounter++;
			DarjeelingStillOnMap = false;
			ThymeStillOnMap = false;
			frontTalkPanel.SetActive(false);
		}
	}

	void makeDarjeelingMatchaConvo()
	{
		if (DarjeelingAndMatchaEncounter == 0) {
			print (numInConvo);
			if (numInConvo >= DarjeelingAndMatchaConvo0.Length)
				endDialogueTurn();
			else
				makeConvo (DarjeelingAndMatchaConvo0[numInConvo]);
		}

		else if (DarjeelingAndMatchaEncounter == 1) {
			if (numInConvo >= DarjeelingAndMatchaConvo1.Length)
				endDialogueTurn ();
			else
				makeConvo (DarjeelingAndMatchaConvo1[numInConvo]);
		}

		else if (DarjeelingAndMatchaEncounter == 2) {
			if (numInConvo >= DarjeelingAndMatchaConvo2.Length)
				endDialogueTurn ();
			else
				makeConvo (DarjeelingAndMatchaConvo2[numInConvo]);
		}
		else if (DarjeelingAndMatchaEncounter == 3) {
			makeConvo (DarjeelingAndMatchaConvo3[numInConvo]);
			if (numInConvo >= DarjeelingAndMatchaConvo3.Length)
				endDialogueTurn ();
			else
				makeConvo (DarjeelingAndMatchaConvo3[numInConvo]);
			DarjeelingAndThymeEncounter++;
			DarjeelingStillOnMap = false;
			MatchaStillOnMap = false;
			frontTalkPanel.SetActive(false);
		}
	}
	void makeDarjeelingPepperConvo()
	{
		if (DarjeelingAndPepperEncounter == 0) {
			print (numInConvo);
			if (numInConvo >= DarjeelingAndPepperConvo0.Length)
				endDialogueTurn ();
			else
				makeConvo (DarjeelingAndPepperConvo0[numInConvo]);
		}

		else if (DarjeelingAndPepperEncounter == 1) {
			if (numInConvo >= DarjeelingAndPepperConvo1.Length)
				endDialogueTurn ();
			else
				makeConvo (DarjeelingAndPepperConvo1[numInConvo]);
		}
		else if (DarjeelingAndPepperEncounter == 2) {
			if (numInConvo >= DarjeelingAndPepperConvo2.Length)
				endDialogueTurn ();
			else
				makeConvo (DarjeelingAndPepperConvo2[numInConvo]);

		}
		else if (DarjeelingAndPepperEncounter == 3) {
			if (numInConvo >= DarjeelingAndPepperConvo3.Length)
				endDialogueTurn ();
			else
				makeConvo (DarjeelingAndPepperConvo3[numInConvo]);
			DarjeelingAndPepperEncounter++;
			DarjeelingStillOnMap = false;
			PepperStillOnMap = false;
			frontTalkPanel.SetActive(false);
		}
	}

	void makeChrisThymeConvo()
	{
		if (ChrisAndThymeEncounter == 0) {
			print (numInConvo);
			if (numInConvo >= ChrisAndThymeConvo0.Length)
				endDialogueTurn ();
			else
				makeConvo (ChrisAndThymeConvo0[numInConvo]);
		}

		else if (ChrisAndThymeEncounter == 1) {
			if (numInConvo >= ChrisAndThymeConvo1.Length)
				endDialogueTurn ();
			else
				makeConvo (ChrisAndThymeConvo1[numInConvo]);
		}
		else if (ChrisAndThymeEncounter == 2) {
			if (numInConvo >= ChrisAndThymeConvo2.Length)
				endDialogueTurn ();
			else
				makeConvo (ChrisAndThymeConvo2[numInConvo]);

		}
		else if (ChrisAndThymeEncounter == 3) {
			if (numInConvo >= ChrisAndThymeConvo3.Length)
				endDialogueTurn ();
			else
				makeConvo (ChrisAndThymeConvo3[numInConvo]);
			ChrisAndThymeEncounter++;
			ChrisStillOnMap = false;
			ThymeStillOnMap = false;
			frontTalkPanel.SetActive(false);
		}
	}

	void makeChrisMatchaConvo()
	{
		if (ChrisAndMatchaEncounter == 0) {
			print (numInConvo);
			if (numInConvo >= ChrisAndMatchaConvo0.Length)
				endDialogueTurn();
			else
				makeConvo (ChrisAndMatchaConvo0[numInConvo]);
		}

		else if (ChrisAndMatchaEncounter == 1) {
			if (numInConvo >= ChrisAndMatchaConvo1.Length)
				endDialogueTurn ();
			else
				makeConvo (ChrisAndMatchaConvo1[numInConvo]);
		}

		else if (ChrisAndMatchaEncounter == 2) {
			if (numInConvo >= ChrisAndMatchaConvo2.Length)
				endDialogueTurn ();
			else
				makeConvo (ChrisAndMatchaConvo2[numInConvo]);
		}
		else if (ChrisAndMatchaEncounter == 3) {
			makeConvo (ChrisAndMatchaConvo3[numInConvo]);
			if (numInConvo >= ChrisAndMatchaConvo3.Length)
				endDialogueTurn ();
			else
				makeConvo (ChrisAndMatchaConvo3[numInConvo]);
			ChrisAndThymeEncounter++;
			ChrisStillOnMap = false;
			MatchaStillOnMap = false;
			frontTalkPanel.SetActive(false);
		}
	}
	void makeChrisPepperConvo()
	{
		if (ChrisAndPepperEncounter == 0) {
			print (numInConvo);
			if (numInConvo >= ChrisAndPepperConvo0.Length)
				endDialogueTurn ();
			else
				makeConvo (ChrisAndPepperConvo0[numInConvo]);
		}

		else if (ChrisAndPepperEncounter == 1) {
			if (numInConvo >= ChrisAndPepperConvo1.Length)
				endDialogueTurn ();
			else
				makeConvo (ChrisAndPepperConvo1[numInConvo]);
		}
		else if (ChrisAndPepperEncounter == 2) {
			if (numInConvo >= ChrisAndPepperConvo2.Length)
				endDialogueTurn ();
			else
				makeConvo (ChrisAndPepperConvo2[numInConvo]);

		}
		else if (ChrisAndPepperEncounter == 3) {
			if (numInConvo >= ChrisAndPepperConvo3.Length)
				endDialogueTurn ();
			else
				makeConvo (ChrisAndPepperConvo3[numInConvo]);
			ChrisAndPepperEncounter++;
			ChrisStillOnMap = false;
			PepperStillOnMap = false;
			frontTalkPanel.SetActive(false);
		}
	}


		void makeThistleThymeConvo()
		{
			if (ThistleAndThymeEncounter == 0) {
				print (numInConvo);
				if (numInConvo >= ThistleAndThymeConvo0.Length)
					endDialogueTurn ();
				else
					makeConvo (ThistleAndThymeConvo0[numInConvo]);
			}

			else if (ThistleAndThymeEncounter == 1) {
				if (numInConvo >= ThistleAndThymeConvo1.Length)
					endDialogueTurn ();
				else
					makeConvo (ThistleAndThymeConvo1[numInConvo]);
			}
			else if (ThistleAndThymeEncounter == 2) {
				if (numInConvo >= ThistleAndThymeConvo2.Length)
					endDialogueTurn ();
				else
					makeConvo (ThistleAndThymeConvo2[numInConvo]);

			}
			else if (ThistleAndThymeEncounter == 3) {
				if (numInConvo >= ThistleAndThymeConvo3.Length)
					endDialogueTurn ();
				else
					makeConvo (ThistleAndThymeConvo3[numInConvo]);
				ThistleAndThymeEncounter++;
				ThistleStillOnMap = false;
				ThymeStillOnMap = false;
				frontTalkPanel.SetActive(false);
			}
		}

		void makeThistleMatchaConvo()
		{
			if (ThistleAndMatchaEncounter == 0) {
				print (numInConvo);
				if (numInConvo >= ThistleAndMatchaConvo0.Length)
					endDialogueTurn();
				else
					makeConvo (ThistleAndMatchaConvo0[numInConvo]);
			}

			else if (ThistleAndMatchaEncounter == 1) {
				if (numInConvo >= ThistleAndMatchaConvo1.Length)
					endDialogueTurn ();
				else
					makeConvo (ThistleAndMatchaConvo1[numInConvo]);
			}

			else if (ThistleAndMatchaEncounter == 2) {
				if (numInConvo >= ThistleAndMatchaConvo2.Length)
					endDialogueTurn ();
				else
					makeConvo (ThistleAndMatchaConvo2[numInConvo]);
			}
			else if (ThistleAndMatchaEncounter == 3) {
				makeConvo (ThistleAndMatchaConvo3[numInConvo]);
				if (numInConvo >= ThistleAndMatchaConvo3.Length)
					endDialogueTurn ();
				else
					makeConvo (ThistleAndMatchaConvo3[numInConvo]);
				ThistleAndThymeEncounter++;
				ThistleStillOnMap = false;
				MatchaStillOnMap = false;
				frontTalkPanel.SetActive(false);
			}
		}
		void makeThistlePepperConvo()
		{
			if (ThistleAndPepperEncounter == 0) {
				print (numInConvo);
				if (numInConvo >= ThistleAndPepperConvo0.Length)
					endDialogueTurn ();
				else
					makeConvo (ThistleAndPepperConvo0[numInConvo]);
			}

			else if (ThistleAndPepperEncounter == 1) {
				if (numInConvo >= ThistleAndPepperConvo1.Length)
					endDialogueTurn ();
				else
					makeConvo (ThistleAndPepperConvo1[numInConvo]);
			}
			else if (ThistleAndPepperEncounter == 2) {
				if (numInConvo >= ThistleAndPepperConvo2.Length)
					endDialogueTurn ();
				else
					makeConvo (ThistleAndPepperConvo2[numInConvo]);

			}
			else if (ThistleAndPepperEncounter == 3) {
				if (numInConvo >= ThistleAndPepperConvo3.Length)
					endDialogueTurn ();
				else
					makeConvo (ThistleAndPepperConvo3[numInConvo]);
				ThistleAndPepperEncounter++;
				ThistleStillOnMap = false;
				PepperStillOnMap = false;
				frontTalkPanel.SetActive(false);
			}
		}







	void makeConvo(string convoLine){

		Debug.Log (convoLine);
		//Debug.Log (numInConvo);

		string[] Line = convoLine.Split (':');
		frontTalkPanel.SetActive(true);
		printStringArray (Line);

		//Debug.Log (Line[0]);
		Debug.Log(numInConvo+ " is apparantly not greater than " + Line.Length);
		if (numInConvo >= Line.Length) {


		} 

		else {
			makeDialogue (Line [0], Line [1], Line [2]);
		}
	

	}

	void makeDialogue(string character, string emotion, string dialogue){

		string fullCharacterName = getCharacter (character);
		//Debug.Log (fullCharacterName);

		Sprite characterSprite = getSprite(fullCharacterName,emotion); //change to canvas

		if (fullCharacterName == "Darjeeling" || fullCharacterName == "Chris" || fullCharacterName == "Thistle") {
			Debug.Log ("Changed PRINCE SPRITE");
			talkingPrince.GetComponent<Image>().sprite = characterSprite; //change to canvas
		}

		if (fullCharacterName == "Thyme" || fullCharacterName == "Matcha" || fullCharacterName == "Pepper") {
			 Debug.Log ("Changed PRINCESSSSSSSSSSSS SPRITE");
			talkingPrincess.GetComponent<Image> ().sprite = characterSprite; //change to canvas
		}

		theText.text = dialogue;
		personSpeaking.text = fullCharacterName;


	}



	string getCharacter(string characterSimple){

		if (characterSimple == " D") {
			return "Darjeeling";
		}
		else if (characterSimple == " C") {
			return "Chris";
		}
		else if (characterSimple == " TL") {
			return "Thistle";
		}
		else if (characterSimple == " TM") {
			return "Thyme";
		}
		else if (characterSimple == " M") {
			return "Matcha";
		}
		else if (characterSimple == " P") {
			return "Pepper";
		}
		return null;
	}

	Sprite getSprite(string character, string emotion){
		if (character == "Darjeeling") {
			if (emotion == "normal")
				return DarjeelingNormal;
			else if (emotion == "happy")
				return DarjeelingHappy;
			else if (emotion == "sad")
				return DarjeelingSad;
			else if (emotion == "angry")
				return DarjeelingAngry;
			else if (emotion == "excited")
				return DarjeelingExcited;
			else if (emotion == "dissappointed")
				return DarjeelingDissappointed;
			else if (emotion == "blush")
				return DarjeelingBlush;
			else 
				return DarjeelingNormal; 
		}
		if (character == "Chris") {
			if (emotion == "normal")
				return ChrisNormal;
			else if (emotion == "happy")
				return ChrisHappy;
			else if (emotion == "sad")
				return ChrisSad;
			else if (emotion == "angry")
				return ChrisAngry;
			else if (emotion == "excited")
				return ChrisExcited;
			else if (emotion == "dissappointed")
				return ChrisDissappointed;
			else if (emotion == "blush")
				return ChrisBlush;
			else 
				return ChrisNormal; 
		}
		if (character == "Thistle") {
			if (emotion == "normal")
				return ThistleNormal;
			else if (emotion == "happy")
				return ThistleHappy;
			else if (emotion == "sad")
				return ThistleSad;
			else if (emotion == "angry")
				return ThistleAngry;
			else if (emotion == "excited")
				return ThistleExcited;
			else if (emotion == "dissappointed")
				return ThistleDissappointed;
			else if (emotion == "blush")
				return ThistleBlush;
			else 
				return ThistleNormal; 
		}
		if (character == "Thyme") {
			if (emotion == "normal")
				return ThymeNormal;
			else if (emotion == "happy")
				return ThymeHappy;
			else if (emotion == "sad")
				return ThymeSad;
			else if (emotion == "angry")
				return ThymeAngry;
			else if (emotion == "excited")
				return ThymeExcited;
			else if (emotion == "dissappointed")
				return ThymeDissappointed;
			else if (emotion == "blush")
				return ThymeBlush;
			else 
				return ThymeNormal; 
		}
		if (character == "Matcha") {
			if (emotion == "normal")
				return MatchaNormal;
			else if (emotion == "happy")
				return MatchaHappy;
			else if (emotion == "sad")
				return MatchaSad;
			else if (emotion == "angry")
				return MatchaAngry;
			else if (emotion == "excited")
				return MatchaExcited;
			else if (emotion == "dissappointed")
				return MatchaDissappointed;
			else if (emotion == "blush")
				return MatchaBlush;
			else 
				return MatchaNormal; 
		}

		if (character == "Pepper") {
			if (emotion == "normal")
				return PepperNormal;
			else if (emotion == "happy")
				return PepperHappy;
			else if (emotion == "sad")
				return PepperSad;
			else if (emotion == "angry")
				return PepperAngry;
			else if (emotion == "excited")
				return PepperExcited;
			else if (emotion == "dissappointed")
				return PepperDissappointed;
			else if (emotion == "blush")
				return PepperBlush;
			else 
				return PepperNormal; 
		}

		return null;
	}

	public void proceedConvo(){
		numInConvo++;
			
	}

	void updateMeetingVariables(){

		if (GameManager.GetComponent<TurnController> ().princess1InCastle1WithPrince1
		    || GameManager.GetComponent<TurnController> ().princess1InCastle2WithPrince1
		    || GameManager.GetComponent<TurnController> ().princess1InCastle3WithPrince1
		    || GameManager.GetComponent<TurnController> ().princess1InCastle4WithPrince1) {

			DarjeelingAndThymeMeet = true;
		}

		if (GameManager.GetComponent<TurnController> ().princess1InCastle1WithPrince2
			|| GameManager.GetComponent<TurnController> ().princess1InCastle2WithPrince2
			|| GameManager.GetComponent<TurnController> ().princess1InCastle3WithPrince2
			|| GameManager.GetComponent<TurnController> ().princess1InCastle4WithPrince2) {

			ChrisAndThymeMeet = true;
		}
		if (GameManager.GetComponent<TurnController> ().princess1InCastle1WithPrince3
			|| GameManager.GetComponent<TurnController> ().princess1InCastle2WithPrince3
			|| GameManager.GetComponent<TurnController> ().princess1InCastle3WithPrince3
			|| GameManager.GetComponent<TurnController> ().princess1InCastle4WithPrince3) {

			ThistleAndThymeMeet = true;
		}





		if (GameManager.GetComponent<TurnController> ().princess2InCastle1WithPrince1
			|| GameManager.GetComponent<TurnController> ().princess2InCastle2WithPrince1
			|| GameManager.GetComponent<TurnController> ().princess2InCastle3WithPrince1
			|| GameManager.GetComponent<TurnController> ().princess2InCastle4WithPrince1) {

			DarjeelingAndMatchaMeet = true;
		}

		if (GameManager.GetComponent<TurnController> ().princess2InCastle1WithPrince2
			|| GameManager.GetComponent<TurnController> ().princess2InCastle2WithPrince2
			|| GameManager.GetComponent<TurnController> ().princess2InCastle3WithPrince2
			|| GameManager.GetComponent<TurnController> ().princess2InCastle4WithPrince2) {

			ChrisAndMatchaMeet = true;
		}
		if (GameManager.GetComponent<TurnController> ().princess2InCastle1WithPrince3
			|| GameManager.GetComponent<TurnController> ().princess2InCastle2WithPrince3
			|| GameManager.GetComponent<TurnController> ().princess2InCastle3WithPrince3
			|| GameManager.GetComponent<TurnController> ().princess2InCastle4WithPrince3) {

			ThistleAndMatchaMeet = true;
		}





		if (GameManager.GetComponent<TurnController> ().princess3InCastle1WithPrince1
			|| GameManager.GetComponent<TurnController> ().princess3InCastle2WithPrince1
			|| GameManager.GetComponent<TurnController> ().princess3InCastle3WithPrince1
			|| GameManager.GetComponent<TurnController> ().princess3InCastle4WithPrince1) {

			DarjeelingAndPepperMeet = true;
		}

		if (GameManager.GetComponent<TurnController> ().princess3InCastle1WithPrince2
			|| GameManager.GetComponent<TurnController> ().princess3InCastle2WithPrince2
			|| GameManager.GetComponent<TurnController> ().princess3InCastle3WithPrince2
			|| GameManager.GetComponent<TurnController> ().princess3InCastle4WithPrince2) {

			ChrisAndPepperMeet = true;
		}
		if (GameManager.GetComponent<TurnController> ().princess3InCastle1WithPrince3
			|| GameManager.GetComponent<TurnController> ().princess3InCastle2WithPrince3
			|| GameManager.GetComponent<TurnController> ().princess3InCastle3WithPrince3
			|| GameManager.GetComponent<TurnController> ().princess3InCastle4WithPrince3) {

			ThistleAndPepperMeet = true;
		}

	}


	string[] getRidOfBlankArray(string[] stringArray)
	{
		List<string> returnStringList = new List<string>();


		int i = 0;
		while ( i < stringArray.Length )
		{
			if (stringArray [i] != " " && stringArray [i] != ""  && stringArray [i] != "\n") {
				returnStringList.Add(stringArray[i]);
			}
			i++;
		}
		//printStringArray (returnStringList.ToArray ());
		return (returnStringList.ToArray ());

	}
	void printStringArray(string[] stringArray){
		int i = 0;
		while ( i < stringArray.Length )
		{
			Debug.Log( stringArray[i] );
			i++;
		}
	}

	void endDialogueTurn()
	{
		if (DarjeelingAndThymeMeet){
			DarjeelingAndThymeEncounter++;
		}
		else if (DarjeelingAndMatchaMeet){
			DarjeelingAndMatchaEncounter++;
		}
		else if (DarjeelingAndPepperMeet){
			DarjeelingAndPepperEncounter++;
		}
		else if (ChrisAndThymeMeet){
			ChrisAndThymeEncounter++;
		}
		else if (ChrisAndMatchaMeet){
			ChrisAndMatchaEncounter++;
		}
		else if (ChrisAndPepperMeet){
			ChrisAndPepperEncounter++;
		}
		else if (ThistleAndThymeMeet){
			ThistleAndThymeEncounter++;
		}
		else if (ThistleAndMatchaMeet){
			ThistleAndMatchaEncounter++;
		}
		else if (ThistleAndPepperMeet){
			ThistleAndPepperEncounter++;
		}


		frontTalkPanel.SetActive (false);
		numInConvo = 0;
		DarjeelingAndThymeMeet = false;
		DarjeelingAndMatchaMeet = false;
		DarjeelingAndPepperMeet = false;
		ChrisAndThymeMeet = false;
		ChrisAndMatchaMeet = false;
		ChrisAndPepperMeet = false;
		ThistleAndThymeMeet = false;
		ThistleAndMatchaMeet = false;
		ThistleAndPepperMeet = false;

		talkingPrince.GetComponent<SpriteRenderer> ().sprite = null;
		talkingPrincess.GetComponent<SpriteRenderer> ().sprite = null;
		theText.text = null;
		personSpeaking.text = null;
		GameManager.GetComponent<TurnController> ().isPlayerTurn = 0;


	}


}
