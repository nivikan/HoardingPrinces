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
	public Sprite currPrinceToDragonSprite;

	public Text theText;
	public Text personSpeaking;
	public GameObject frontTalkPanel;
	public GameObject talkingPrincess;
	public GameObject talkingPrince;
	public GameObject talkingPrinceToDragon;
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
	public string[] DarjeelingAndThymeConvo3_GoAwayNoMet;
	public string[] DarjeelingAndThymeConvo4_GoAwayYesMet;

	public TextAsset DarjeelingAndMatcha;
	public int DarjeelingAndMatchaEncounter = 0;
	public string[] DarjeelingAndMatchaConvo0;
	public string[] DarjeelingAndMatchaConvo1;
	public string[] DarjeelingAndMatchaConvo2;
	public string[] DarjeelingAndMatchaConvo3_GoAwayNoMet;
	public string[] DarjeelingAndMatchaConvo4_GoAwayYesMet;

	public TextAsset DarjeelingAndPepper;
	public int DarjeelingAndPepperEncounter = 0;
	public string[] DarjeelingAndPepperConvo0;
	public string[] DarjeelingAndPepperConvo1;
	public string[] DarjeelingAndPepperConvo2;
	public string[] DarjeelingAndPepperConvo3_GoAwayNoMet;
	public string[] DarjeelingAndPepperConvo4_GoAwayYesMet;


	public TextAsset ChrisAndThyme;
	public int ChrisAndThymeEncounter = 0;
	public string[] ChrisAndThymeConvo0;
	public string[] ChrisAndThymeConvo1;
	public string[] ChrisAndThymeConvo2;
	public string[] ChrisAndThymeConvo3_GoAwayNoMet;
	public string[] ChrisAndThymeConvo4_GoAwayYesMet;

	public TextAsset ChrisAndMatcha;
	public int ChrisAndMatchaEncounter = 0;
	public string[] ChrisAndMatchaConvo0;
	public string[] ChrisAndMatchaConvo1;
	public string[] ChrisAndMatchaConvo2;
	public string[] ChrisAndMatchaConvo3_GoAwayNoMet;
	public string[] ChrisAndMatchaConvo4_GoAwayYesMet;

	public TextAsset ChrisAndPepper;
	public int ChrisAndPepperEncounter = 0;
	public string[] ChrisAndPepperConvo0;
	public string[] ChrisAndPepperConvo1;
	public string[] ChrisAndPepperConvo2;
	public string[] ChrisAndPepperConvo3_GoAwayNoMet;
	public string[] ChrisAndPepperConvo4_GoAwayYesMet;



	public TextAsset ThistleAndThyme;
	public int ThistleAndThymeEncounter = 0;
	public string[] ThistleAndThymeConvo0;
	public string[] ThistleAndThymeConvo1;
	public string[] ThistleAndThymeConvo2;
	public string[] ThistleAndThymeConvo3_GoAwayNoMet;
	public string[] ThistleAndThymeConvo4_GoAwayYesMet;

	public TextAsset ThistleAndMatcha;
	public int ThistleAndMatchaEncounter = 0;
	public string[] ThistleAndMatchaConvo0;
	public string[] ThistleAndMatchaConvo1;
	public string[] ThistleAndMatchaConvo2;
	public string[] ThistleAndMatchaConvo3_GoAwayNoMet;
	public string[] ThistleAndMatchaConvo4_GoAwayYesMet;

	public TextAsset ThistleAndPepper;
	public int ThistleAndPepperEncounter = 0;
	public string[] ThistleAndPepperConvo0;
	public string[] ThistleAndPepperConvo1;
	public string[] ThistleAndPepperConvo2;
	public string[] ThistleAndPepperConvo3_GoAwayNoMet;
	public string[] ThistleAndPepperConvo4_GoAwayYesMet;



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




	// DRAGON CONVO VARIABLES

	public int CountingDragonPrinceTime = 0;

	public TextAsset DarjeelingAndDragon;
	public int DarjeelingAndDragonEncounter = 0;
	public string[] DarjeelingAndDragonConvo0;
	public string[] DarjeelingAndDragonConvo1;
	public string[] DarjeelingAndDragonConvo2;
	public string[] DarjeelingAndDragonConvo3;


	public TextAsset ChrisAndDragon;
	public int ChrisAndDragonEncounter = 0;
	public string[] ChrisAndDragonConvo0;
	public string[] ChrisAndDragonConvo1;
	public string[] ChrisAndDragonConvo2;
	public string[] ChrisAndDragonConvo3;

	public TextAsset ThistleAndDragon;
	public int ThistleAndDragonEncounter = 0;
	public string[] ThistleAndDragonConvo0;
	public string[] ThistleAndDragonConvo1;
	public string[] ThistleAndDragonConvo2;
	public string[] ThistleAndDragonConvo3;


	public bool DarjeelingAlone = false;
	public bool ChrisAlone = false;
	public bool ThistleAlone = false;

	public bool DarjeelingAndDragonMeet = false;
	public bool ChrisAndDragonMeet = false;
	public bool ThistleAndDragonMeet = false;



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

			DarjeelingAndThymeConvo3_GoAwayNoMet = getRidOfBlankArray(AllConvos[3].Split ('\n'));
			printStringArray (DarjeelingAndThymeConvo3_GoAwayNoMet);
			//printStringArray(DarjeelingAndThymeConvo3);
			//DarjeelingAndThymeConvo3 = getRidOfBlankArray (DarjeelingAndThymeConvo3);

			//DarjeelingAndThymeConvo4_GoAwayYesMet = getRidOfBlankArray(AllConvos[4].Split ('\n'));
			//printStringArray (DarjeelingAndThymeConvo4_GoAwayYesMet);
			//printStringArray(DarjeelingAndThymeConvo3);
			//DarjeelingAndThymeConvo3 = getRidOfBlankArray (DarjeelingAndThymeConvo3);


		}
		if (DarjeelingAndMatcha != null) {
			string[] AllConvos = (DarjeelingAndMatcha.text.Split ('/'));
			DarjeelingAndMatchaConvo0 = getRidOfBlankArray(AllConvos[0].Split ('\n'));
			DarjeelingAndMatchaConvo1 = getRidOfBlankArray(AllConvos[1].Split ('\n'));
			DarjeelingAndMatchaConvo2 = getRidOfBlankArray(AllConvos[2].Split ('\n'));
			DarjeelingAndMatchaConvo3_GoAwayNoMet = getRidOfBlankArray(AllConvos[3].Split ('\n'));
			//DarjeelingAndMatchaConvo4_GoAwayYesMet = getRidOfBlankArray(AllConvos[4].Split ('\n'));
		}
		if (DarjeelingAndPepper != null) {
			string[] AllConvos = (DarjeelingAndPepper.text.Split ('/'));
			DarjeelingAndPepperConvo0 = getRidOfBlankArray(AllConvos[0].Split ('\n'));
			DarjeelingAndPepperConvo1 = getRidOfBlankArray(AllConvos[1].Split ('\n'));
			DarjeelingAndPepperConvo2 = getRidOfBlankArray(AllConvos[2].Split ('\n'));
			DarjeelingAndPepperConvo3_GoAwayNoMet = getRidOfBlankArray(AllConvos[3].Split ('\n'));
			//DarjeelingAndPepperConvo4_GoAwayYesMet = getRidOfBlankArray(AllConvos[4].Split ('\n'));
		}



		//Prince Chris
		if (ChrisAndThyme != null) {
			string[] AllConvos = (ChrisAndThyme.text.Split ('/'));
			ChrisAndThymeConvo0 = getRidOfBlankArray(AllConvos[0].Split ('\n'));
			ChrisAndThymeConvo1 = getRidOfBlankArray(AllConvos[1].Split ('\n'));
			ChrisAndThymeConvo2 = getRidOfBlankArray(AllConvos[2].Split ('\n'));
			ChrisAndThymeConvo3_GoAwayNoMet = getRidOfBlankArray(AllConvos[3].Split ('\n'));
			//ChrisAndThymeConvo4_GoAwayYesMet = getRidOfBlankArray(AllConvos[4].Split ('\n'));
		}
		if (ChrisAndMatcha != null) {
			string[] AllConvos = (ChrisAndMatcha.text.Split ('/'));
			ChrisAndMatchaConvo0 = getRidOfBlankArray(AllConvos[0].Split ('\n'));
			ChrisAndMatchaConvo1 = getRidOfBlankArray(AllConvos[1].Split ('\n'));
			ChrisAndMatchaConvo2 = getRidOfBlankArray(AllConvos[2].Split ('\n'));
			ChrisAndMatchaConvo3_GoAwayNoMet = getRidOfBlankArray(AllConvos[3].Split ('\n'));
			//ChrisAndMatchaConvo4_GoAwayYesMet = getRidOfBlankArray(AllConvos[4].Split ('\n'));
		}
		if (ChrisAndPepper != null) {
			string[] AllConvos = (ChrisAndPepper.text.Split ('/'));
			ChrisAndPepperConvo0 = getRidOfBlankArray(AllConvos[0].Split ('\n'));
			ChrisAndPepperConvo1 = getRidOfBlankArray(AllConvos[1].Split ('\n'));
			ChrisAndPepperConvo2 = getRidOfBlankArray(AllConvos[2].Split ('\n'));
			ChrisAndPepperConvo3_GoAwayNoMet = getRidOfBlankArray(AllConvos[3].Split ('\n'));
			//ChrisAndPepperConvo4_GoAwayYesMet = getRidOfBlankArray(AllConvos[4].Split ('\n'));
		}



		//Prince Thistle
		if (ThistleAndThyme != null) {
			string[] AllConvos = (ThistleAndThyme.text.Split ('/'));
			ThistleAndThymeConvo0 = getRidOfBlankArray(AllConvos[0].Split ('\n'));
			ThistleAndThymeConvo1 = getRidOfBlankArray(AllConvos[1].Split ('\n'));
			ThistleAndThymeConvo2 = getRidOfBlankArray(AllConvos[2].Split ('\n'));
			ThistleAndThymeConvo3_GoAwayNoMet = getRidOfBlankArray(AllConvos[3].Split ('\n'));
			//ThistleAndThymeConvo4_GoAwayYesMet = getRidOfBlankArray(AllConvos[4].Split ('\n'));
		}
		if (ThistleAndMatcha != null) {
			string[] AllConvos = (ThistleAndMatcha.text.Split ('/'));
			ThistleAndMatchaConvo0 = getRidOfBlankArray(AllConvos[0].Split ('\n'));
			ThistleAndMatchaConvo1 = getRidOfBlankArray(AllConvos[1].Split ('\n'));
			ThistleAndMatchaConvo2 = getRidOfBlankArray(AllConvos[2].Split ('\n'));
			ThistleAndMatchaConvo3_GoAwayNoMet = getRidOfBlankArray(AllConvos[3].Split ('\n'));
			//ThistleAndMatchaConvo4_GoAwayYesMet = getRidOfBlankArray(AllConvos[4].Split ('\n'));
		}
		if (ThistleAndPepper != null) {
			string[] AllConvos = (ThistleAndPepper.text.Split ('/'));
			ThistleAndPepperConvo0 = getRidOfBlankArray(AllConvos[0].Split ('\n'));
			ThistleAndPepperConvo1 = getRidOfBlankArray(AllConvos[1].Split ('\n'));
			ThistleAndPepperConvo2 = getRidOfBlankArray(AllConvos[2].Split ('\n'));
			ThistleAndPepperConvo3_GoAwayNoMet = getRidOfBlankArray(AllConvos[3].Split ('\n'));
			//ThistleAndPepperConvo4_GoAwayYesMet = getRidOfBlankArray(AllConvos[4].Split ('\n'));
		}

		//DRAGON
		if (ThistleAndDragon != null) {
			string[] AllConvos = (ThistleAndDragon.text.Split ('/'));
			ThistleAndDragonConvo0 = getRidOfBlankArray(AllConvos[0].Split ('\n'));
			ThistleAndDragonConvo1 = getRidOfBlankArray(AllConvos[1].Split ('\n'));
			ThistleAndDragonConvo2 = getRidOfBlankArray(AllConvos[2].Split ('\n'));
			ThistleAndDragonConvo3 = getRidOfBlankArray(AllConvos[3].Split ('\n'));
		}
		if (ChrisAndDragon != null) {
			string[] AllConvos = (ChrisAndDragon.text.Split ('/'));
			ChrisAndDragonConvo0 = getRidOfBlankArray(AllConvos[0].Split ('\n'));
			ChrisAndDragonConvo1 = getRidOfBlankArray(AllConvos[1].Split ('\n'));
			ChrisAndDragonConvo2 = getRidOfBlankArray(AllConvos[2].Split ('\n'));
			ChrisAndDragonConvo3 = getRidOfBlankArray(AllConvos[3].Split ('\n'));
		}
		if (DarjeelingAndDragon != null) {
			string[] AllConvos = (DarjeelingAndDragon.text.Split ('/'));
			DarjeelingAndDragonConvo0 = getRidOfBlankArray(AllConvos[0].Split ('\n'));
			DarjeelingAndDragonConvo1 = getRidOfBlankArray(AllConvos[1].Split ('\n'));
			DarjeelingAndDragonConvo2 = getRidOfBlankArray(AllConvos[2].Split ('\n'));
			DarjeelingAndDragonConvo3 = getRidOfBlankArray(AllConvos[3].Split ('\n'));
		}






		
	}
	
	// Update is called once per frame
	void Update () {


		if (GameManager.GetComponent<TurnController> ().isPlayerTurn == 3) {

			updateMeetingVariables ();
			updateVariables ();

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



			////////////////////////////////////////////////////////////////////////////////////////////////////////
			/////////////CHECK IF PRINCESSES MEET PRINCES & START TALKING 
			////////////////////////////////////////////////////////////////////////////////////////////////////////



			if (DarjeelingAndThymeMeet) {
				currPrinceSprite = getSprite("Darjeeling","normal");
				currPrincessSprite = getSprite("Thyme","normal");
				currPrinceToDragonSprite = null;

				talkingPrince.SetActive (true);
				talkingPrincess.SetActive (true);
				talkingPrinceToDragon.SetActive (false);

				talkingPrince.GetComponent<Image>().sprite = currPrinceSprite;
				talkingPrincess.GetComponent<Image>().sprite = currPrincessSprite;

				makeDarjeelingThymeConvo ();
			}

			else if (DarjeelingAndMatchaMeet) {
				currPrinceSprite = getSprite("Darjeeling","normal");
				currPrincessSprite = getSprite("Matcha","normal");
				currPrinceToDragonSprite = null;

				talkingPrince.SetActive (true);
				talkingPrincess.SetActive (true);
				talkingPrinceToDragon.SetActive (false);

				talkingPrince.GetComponent<Image>().sprite = currPrinceSprite;
				talkingPrincess.GetComponent<Image>().sprite = currPrincessSprite;

				makeDarjeelingMatchaConvo ();
			}

			else if (DarjeelingAndPepperMeet) {
				currPrinceSprite = getSprite("Darjeeling","normal");
				currPrincessSprite = getSprite("Pepper","normal");
				currPrinceToDragonSprite = null;

				talkingPrince.SetActive (true);
				talkingPrincess.SetActive (true);
				talkingPrinceToDragon.SetActive (false);

				talkingPrince.GetComponent<Image>().sprite = currPrinceSprite;
				talkingPrincess.GetComponent<Image>().sprite = currPrincessSprite;

				makeDarjeelingPepperConvo ();
			}

			//CHRIS
			else if (ChrisAndThymeMeet) {
				currPrinceSprite = getSprite("Chris","normal");
				currPrincessSprite = getSprite("Thyme","normal");

				talkingPrince.SetActive (true);
				talkingPrincess.SetActive (true);
				talkingPrinceToDragon.SetActive (false);

				talkingPrince.GetComponent<Image>().sprite = currPrinceSprite;
				talkingPrincess.GetComponent<Image>().sprite = currPrincessSprite;


				makeChrisThymeConvo ();
			}

			else if (ChrisAndMatchaMeet) {
				currPrinceSprite = getSprite("Chris","normal");
				currPrincessSprite = getSprite("Matcha","normal");
				currPrinceToDragonSprite = null;

				talkingPrince.SetActive (true);
				talkingPrincess.SetActive (true);
				talkingPrinceToDragon.SetActive (false);

				talkingPrince.GetComponent<Image>().sprite = currPrinceSprite;
				talkingPrincess.GetComponent<Image>().sprite = currPrincessSprite;

				makeChrisMatchaConvo ();
			}

			else if (ChrisAndPepperMeet) {
				currPrinceSprite = getSprite("Chris","normal");
				currPrincessSprite = getSprite("Pepper","normal");
				currPrinceToDragonSprite = null;

				talkingPrince.SetActive (true);
				talkingPrincess.SetActive (true);
				talkingPrinceToDragon.SetActive (false);

				talkingPrince.GetComponent<Image>().sprite = currPrinceSprite;
				talkingPrincess.GetComponent<Image>().sprite = currPrincessSprite;

				makeChrisPepperConvo ();

			}

			//Thistle
			else if (ThistleAndThymeMeet) {
				currPrinceSprite = getSprite("Thistle","normal");
				currPrincessSprite = getSprite("Thyme","normal");
				currPrinceToDragonSprite = null;

				talkingPrince.SetActive (true);
				talkingPrincess.SetActive (true);
				talkingPrinceToDragon.SetActive (false);

				talkingPrince.GetComponent<Image>().sprite = currPrinceSprite;
				talkingPrincess.GetComponent<Image>().sprite = currPrincessSprite;

				makeThistleThymeConvo ();
			}

			else if (ThistleAndMatchaMeet) {
				currPrinceSprite = getSprite("Thistle","normal");
				currPrincessSprite = getSprite("Matcha","normal");
				currPrinceToDragonSprite = null;

				talkingPrince.SetActive (true);
				talkingPrincess.SetActive (true);
				talkingPrinceToDragon.SetActive (false);

				talkingPrince.GetComponent<Image>().sprite = currPrinceSprite;
				talkingPrincess.GetComponent<Image>().sprite = currPrincessSprite;

				makeThistleMatchaConvo ();
			}

			else if (ThistleAndPepperMeet) {
				currPrinceSprite = getSprite("Thistle","normal");
				currPrincessSprite = getSprite("Pepper","normal");
				currPrinceToDragonSprite = null;

				talkingPrince.SetActive (true);
				talkingPrincess.SetActive (true);
				talkingPrinceToDragon.SetActive (false);

				talkingPrince.GetComponent<Image>().sprite = currPrinceSprite;
				talkingPrincess.GetComponent<Image>().sprite = currPrincessSprite;

				makeThistlePepperConvo ();
			}

			else if (DarjeelingAndDragonMeet) {
				Debug.Log ("Darjeeling and Dragon Meeting");
				currPrinceSprite = null;
				currPrincessSprite = null;
				currPrinceToDragonSprite = getSprite("Darjeeling","normal");

				talkingPrince.SetActive (false);
				talkingPrincess.SetActive (false);
				talkingPrinceToDragon.SetActive (true);

				talkingPrinceToDragon.GetComponent<Image>().sprite = currPrinceToDragonSprite;

				makeDarjeelingDragonConvo ();
			}

			else if (ChrisAndDragonMeet) {
				
				currPrinceSprite = null;
				currPrincessSprite = null;
				currPrinceToDragonSprite = getSprite("Chris","normal");

				talkingPrince.SetActive (false);
				talkingPrincess.SetActive (false);
				talkingPrinceToDragon.SetActive (true);

				talkingPrinceToDragon.GetComponent<Image>().sprite = currPrinceToDragonSprite;

				makeChrisDragonConvo ();
			}

			else if (ThistleAndDragonMeet) {
				currPrinceSprite = null;
				currPrincessSprite = null;
				currPrinceToDragonSprite = getSprite("Thistle","normal");

				talkingPrince.SetActive (false);
				talkingPrincess.SetActive (false);
				talkingPrinceToDragon.SetActive (true);

				talkingPrinceToDragon.GetComponent<Image>().sprite = currPrinceToDragonSprite;

				makeThistleDragonConvo ();
			}


			else{
				Debug.Log ("No Convo");
				GameManager.GetComponent<TurnController> ().isPlayerTurn = 0;
			}


			////////////////////////////////////////////////////////////////////////////////////////////////////////
			/////////////CHECK IF ONLY 1 PRINCE IS LEFT AND IMPLEMENT CONVO WITH DRAGON
			////////////////////////////////////////////////////////////////////////////////////////////////////////


			if (DarjeelingAndDragonMeet) {

				currPrinceSprite = null;
				currPrincessSprite = null;
				currPrinceToDragonSprite = getSprite("Darjeeling","normal");

				talkingPrince.SetActive (false);
				talkingPrincess.SetActive (false);
				talkingPrinceToDragon.SetActive (true);
				talkingPrinceToDragon.GetComponent<Image>().sprite = currPrinceToDragonSprite;

				makeDarjeelingDragonConvo ();

			}


			if (ChrisAndDragonMeet) {

				currPrinceSprite = null;
				currPrincessSprite = null;
				currPrinceToDragonSprite = getSprite("Darjeeling","normal");

				talkingPrince.SetActive (false);
				talkingPrincess.SetActive (false);
				talkingPrinceToDragon.SetActive (true);
				talkingPrinceToDragon.GetComponent<Image>().sprite = currPrinceToDragonSprite;

				makeChrisDragonConvo ();

			}


			if (ThistleAndDragonMeet) {

				currPrinceSprite = null;
				currPrincessSprite = null;
				currPrinceToDragonSprite = getSprite("Darjeeling","normal");

				talkingPrince.SetActive (false);
				talkingPrincess.SetActive (false);
				talkingPrinceToDragon.SetActive (true);
				talkingPrinceToDragon.GetComponent<Image>().sprite = currPrinceToDragonSprite;

				makeThistleDragonConvo ();

			}

	}
	}




	void makeDarjeelingThymeConvo()
	{

		if (DarjeelingAlone == true){
			if (DarjeelingAndThymeEncounter == 0) {
				if (numInConvo >= DarjeelingAndThymeConvo3_GoAwayNoMet.Length)
					endDialogueTurn ();
				else
					makeConvo (DarjeelingAndThymeConvo3_GoAwayNoMet[numInConvo]);
			}
			if (DarjeelingAndThymeEncounter > 0) {
				if (numInConvo >= DarjeelingAndThymeConvo4_GoAwayYesMet.Length)
					endDialogueTurn ();
				else
					makeConvo (DarjeelingAndThymeConvo4_GoAwayYesMet[numInConvo]);
			}

		}
		else if (DarjeelingAndThymeEncounter == 0) {
			//print (numInConvo);
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

			//DarjeelingAndThymeEncounter++;
			DarjeelingStillOnMap = false;
			ThymeStillOnMap = false;
			//frontTalkPanel.SetActive(false);
		}
		/*
		 * else if (DarjeelingAndThymeEncounter == 3) {
			if (numInConvo >= DarjeelingAndThymeConvo3_GoAwayNoMet.Length)
				endDialogueTurn ();
			else
				makeConvo (DarjeelingAndThymeConvo3_GoAwayNoMet[numInConvo]);
			DarjeelingAndThymeEncounter++;
			DarjeelingStillOnMap = false;
			ThymeStillOnMap = false;
			frontTalkPanel.SetActive(false);
		}
		*/
	}

	void makeDarjeelingMatchaConvo()
	{
		if (DarjeelingAlone == true){
			if (DarjeelingAndMatchaEncounter == 0) {
				if (numInConvo >= DarjeelingAndMatchaConvo3_GoAwayNoMet.Length)
					endDialogueTurn ();
				else
					makeConvo (DarjeelingAndMatchaConvo3_GoAwayNoMet[numInConvo]);
			}
			if (DarjeelingAndMatchaEncounter > 0) {
				if (numInConvo >= DarjeelingAndMatchaConvo4_GoAwayYesMet.Length)
					endDialogueTurn ();
				else
					makeConvo (DarjeelingAndMatchaConvo4_GoAwayYesMet[numInConvo]);
			}

		}
		else if (DarjeelingAndMatchaEncounter == 0) {
			//print (numInConvo);
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

			DarjeelingStillOnMap = false;
			MatchaStillOnMap = false;
		}
		/*
		else if (DarjeelingAndMatchaEncounter == 3) {
			makeConvo (DarjeelingAndMatchaConvo3_GoAwayNoMet[numInConvo]);
			if (numInConvo >= DarjeelingAndMatchaConvo3_GoAwayNoMet.Length)
				endDialogueTurn ();
			else
				makeConvo (DarjeelingAndMatchaConvo3_GoAwayNoMet[numInConvo]);
			DarjeelingAndThymeEncounter++;
			DarjeelingStillOnMap = false;
			MatchaStillOnMap = false;
			frontTalkPanel.SetActive(false);
		}
		*/
	}
	void makeDarjeelingPepperConvo()
	{
		if (DarjeelingAlone == true){
			if (DarjeelingAndPepperEncounter == 0) {
				if (numInConvo >= DarjeelingAndPepperConvo3_GoAwayNoMet.Length)
					endDialogueTurn ();
				else
					makeConvo (DarjeelingAndPepperConvo3_GoAwayNoMet[numInConvo]);
			}
			if (DarjeelingAndPepperEncounter > 0) {
				if (numInConvo >= DarjeelingAndPepperConvo4_GoAwayYesMet.Length)
					endDialogueTurn ();
				else
					makeConvo (DarjeelingAndPepperConvo4_GoAwayYesMet[numInConvo]);
			}

		}
		else if (DarjeelingAndPepperEncounter == 0) {
			//print (numInConvo);
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

			DarjeelingStillOnMap = false;
			PepperStillOnMap = false;
		}
		/*
		else if (DarjeelingAndPepperEncounter == 3) {
			if (numInConvo >= DarjeelingAndPepperConvo3_GoAwayNoMet.Length)
				endDialogueTurn ();
			else
				makeConvo (DarjeelingAndPepperConvo3_GoAwayNoMet[numInConvo]);
			DarjeelingAndPepperEncounter++;
			DarjeelingStillOnMap = false;
			PepperStillOnMap = false;
			frontTalkPanel.SetActive(false);
		}
		*/
	}

	void makeChrisThymeConvo()
	{
		if (ChrisAlone == true){
			if (ChrisAndThymeEncounter == 0) {
				if (numInConvo >= ChrisAndThymeConvo3_GoAwayNoMet.Length)
					endDialogueTurn ();
				else
					makeConvo (ChrisAndThymeConvo3_GoAwayNoMet[numInConvo]);
			}
			if (ChrisAndThymeEncounter > 0) {
				if (numInConvo >= ChrisAndThymeConvo4_GoAwayYesMet.Length)
					endDialogueTurn ();
				else
					makeConvo (ChrisAndThymeConvo4_GoAwayYesMet[numInConvo]);
			}

		}
		else if (ChrisAndThymeEncounter == 0) {
			//print (numInConvo);
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

			ChrisStillOnMap = false;
			ThymeStillOnMap = false;

		}
		/*
		else if (ChrisAndThymeEncounter == 3) {
			if (numInConvo >= ChrisAndThymeConvo3_GoAwayNoMet.Length)
				endDialogueTurn ();
			else
				makeConvo (ChrisAndThymeConvo3_GoAwayNoMet[numInConvo]);
			ChrisAndThymeEncounter++;
			ChrisStillOnMap = false;
			ThymeStillOnMap = false;
			frontTalkPanel.SetActive(false);
		}
		*/
	}

	void makeChrisMatchaConvo()
	{
		if (ChrisAlone == true){
			if (ChrisAndMatchaEncounter == 0) {
				if (numInConvo >= ChrisAndMatchaConvo3_GoAwayNoMet.Length)
					endDialogueTurn ();
				else
					makeConvo (ChrisAndMatchaConvo3_GoAwayNoMet[numInConvo]);
			}
			if (ChrisAndMatchaEncounter > 0) {
				if (numInConvo >= ChrisAndMatchaConvo4_GoAwayYesMet.Length)
					endDialogueTurn ();
				else
					makeConvo (ChrisAndMatchaConvo4_GoAwayYesMet[numInConvo]);
			}

		}
		else if (ChrisAndMatchaEncounter == 0) {
			//print (numInConvo);
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

			ChrisStillOnMap = false;
			MatchaStillOnMap = false;
		}
		/*
		 * else if (ChrisAndMatchaEncounter == 3) {
			makeConvo (ChrisAndMatchaConvo3_GoAwayNoMet[numInConvo]);
			if (numInConvo >= ChrisAndMatchaConvo3_GoAwayNoMet.Length)
				endDialogueTurn ();
			else
				makeConvo (ChrisAndMatchaConvo3_GoAwayNoMet[numInConvo]);
			ChrisAndThymeEncounter++;
			ChrisStillOnMap = false;
			MatchaStillOnMap = false;
			frontTalkPanel.SetActive(false);
		}
		*/
	}
	void makeChrisPepperConvo()
	{
		if (ChrisAlone == true){
			if (ChrisAndPepperEncounter == 0) {
				if (numInConvo >= ChrisAndPepperConvo3_GoAwayNoMet.Length)
					endDialogueTurn ();
				else
					makeConvo (ChrisAndPepperConvo3_GoAwayNoMet[numInConvo]);
			}
			if (ThistleAndMatchaEncounter > 0) {
				if (numInConvo >= ChrisAndPepperConvo4_GoAwayYesMet.Length)
					endDialogueTurn ();
				else
					makeConvo (ChrisAndPepperConvo4_GoAwayYesMet[numInConvo]);
			}

		}
		else if (ChrisAndPepperEncounter == 0) {
			//print (numInConvo);
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

			ChrisStillOnMap = false;
			PepperStillOnMap = false;

		}

		/*
		else if (ChrisAndPepperEncounter == 3) {
			if (numInConvo >= ChrisAndPepperConvo3_GoAwayNoMet.Length)
				endDialogueTurn ();
			else
				makeConvo (ChrisAndPepperConvo3_GoAwayNoMet[numInConvo]);
			ChrisAndPepperEncounter++;
			ChrisStillOnMap = false;
			PepperStillOnMap = false;
			frontTalkPanel.SetActive(false);
		}
		*/
	}


	void makeThistleThymeConvo()
	{
		if (ThistleAlone == true){
			if (ThistleAndThymeEncounter == 0) {
				if (numInConvo >= ThistleAndThymeConvo3_GoAwayNoMet.Length)
					endDialogueTurn ();
				else
					makeConvo (ThistleAndThymeConvo3_GoAwayNoMet[numInConvo]);
			}
			if (ThistleAndMatchaEncounter > 0) {
				if (numInConvo >= ThistleAndThymeConvo4_GoAwayYesMet.Length)
					endDialogueTurn ();
				else
					makeConvo (ThistleAndThymeConvo4_GoAwayYesMet[numInConvo]);
			}

		}
		else if (ThistleAndThymeEncounter == 0) {
			//print (numInConvo);
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

			ThistleStillOnMap = false;
			ThymeStillOnMap = false;

		}
		/*
			else if (ThistleAndThymeEncounter == 3) {
			if (numInConvo >= ThistleAndThymeConvo3_GoAwayNoMet.Length)
					endDialogueTurn ();
				else
				makeConvo (ThistleAndThymeConvo3_GoAwayNoMet[numInConvo]);
				ThistleAndThymeEncounter++;
				ThistleStillOnMap = false;
				ThymeStillOnMap = false;
				frontTalkPanel.SetActive(false);
			}
			*/
	}

	void makeThistleMatchaConvo()
	{

		if (ThistleAlone == true){
			if (ThistleAndMatchaEncounter == 0) {
				if (numInConvo >= ThistleAndMatchaConvo3_GoAwayNoMet.Length)
					endDialogueTurn ();
				else
					makeConvo (ThistleAndMatchaConvo3_GoAwayNoMet[numInConvo]);
			}
			if (ThistleAndMatchaEncounter > 0) {
				if (numInConvo >= ThistleAndMatchaConvo4_GoAwayYesMet.Length)
					endDialogueTurn ();
				else
					makeConvo (ThistleAndMatchaConvo4_GoAwayYesMet[numInConvo]);
			}

		}
		else if (ThistleAndMatchaEncounter == 0) {
			//print (numInConvo);
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

			ThistleStillOnMap = false;
			MatchaStillOnMap = false;
		}

		/*
			else if (ThistleAndMatchaEncounter == 3) {
			makeConvo (ThistleAndMatchaConvo3_GoAwayNoMet[numInConvo]);
			if (numInConvo >= ThistleAndMatchaConvo3_GoAwayNoMet.Length)
					endDialogueTurn ();
				else
				makeConvo (ThistleAndMatchaConvo3_GoAwayNoMet[numInConvo]);
				ThistleAndThymeEncounter++;
				ThistleStillOnMap = false;
				MatchaStillOnMap = false;
				frontTalkPanel.SetActive(false);
			}
			*/
	}
	void makeThistlePepperConvo()
	{
		if (ThistleAlone == true){
			if (ThistleAndPepperEncounter == 0) {
				if (numInConvo >= ThistleAndPepperConvo3_GoAwayNoMet.Length)
					endDialogueTurn ();
				else
					makeConvo (ThistleAndPepperConvo3_GoAwayNoMet[numInConvo]);
			}
			if (ThistleAndMatchaEncounter > 0) {
				if (numInConvo >= ThistleAndPepperConvo4_GoAwayYesMet.Length)
					endDialogueTurn ();
				else
					makeConvo (ThistleAndPepperConvo4_GoAwayYesMet[numInConvo]);
			}

		}
		else if (ThistleAndPepperEncounter == 0) {
			//print (numInConvo);
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

			ThistleStillOnMap = false;
			PepperStillOnMap = false;

		}
		/*
			else if (ThistleAndPepperEncounter == 3) {
			if (numInConvo >= ThistleAndPepperConvo3_GoAwayNoMet.Length)
					endDialogueTurn ();
				else
				makeConvo (ThistleAndPepperConvo3_GoAwayNoMet[numInConvo]);
				ThistleAndPepperEncounter++;
				ThistleStillOnMap = false;
				PepperStillOnMap = false;
				frontTalkPanel.SetActive(false);
			}
		*/
	}


	void makeDarjeelingDragonConvo()
	{
		Debug.Log ("Called 'makeDarjeelingDragonConvo()'");
		if (CountingDragonPrinceTime ==2) {
			//print (numInConvo);
			if (numInConvo >= DarjeelingAndDragonConvo0.Length)
				endDialogueTurn ();
			else
				makeConvo (DarjeelingAndDragonConvo0[numInConvo]);

		}

		else if (CountingDragonPrinceTime == 5) {
			//print (numInConvo);
			if (numInConvo >= DarjeelingAndDragonConvo1.Length)
				endDialogueTurn ();
			else
				makeConvo (DarjeelingAndDragonConvo1[numInConvo]);
		}

		else if (CountingDragonPrinceTime == 10) {
			//print (numInConvo);
			if (numInConvo >= DarjeelingAndDragonConvo2.Length)
				endDialogueTurn ();
			else
				makeConvo (DarjeelingAndDragonConvo2[numInConvo]);
		}

		else if (CountingDragonPrinceTime == 15) {
			//print (numInConvo);
			if (numInConvo >= DarjeelingAndDragonConvo3.Length)
				endDialogueTurn ();
			else
				makeConvo (DarjeelingAndDragonConvo3[numInConvo]);
		}

	}

	void makeChrisDragonConvo()
	{
		if (CountingDragonPrinceTime ==2) {
			//print (numInConvo);
			if (numInConvo >= ChrisAndDragonConvo0.Length)
				endDialogueTurn ();
			else
				makeConvo (ChrisAndDragonConvo0[numInConvo]);

		}

		else if (CountingDragonPrinceTime == 5) {
			//print (numInConvo);
			if (numInConvo >= ChrisAndDragonConvo1.Length)
				endDialogueTurn ();
			else
				makeConvo (ChrisAndDragonConvo1[numInConvo]);
		}

		else if (CountingDragonPrinceTime == 10) {
			//print (numInConvo);
			if (numInConvo >= ChrisAndDragonConvo2.Length)
				endDialogueTurn ();
			else
				makeConvo (ChrisAndDragonConvo2[numInConvo]);
		}

		else if (CountingDragonPrinceTime == 15) {
			//print (numInConvo);
			if (numInConvo >= ChrisAndDragonConvo3.Length)
				endDialogueTurn ();
			else
				makeConvo (ChrisAndDragonConvo3[numInConvo]);
		}

	}

	void makeThistleDragonConvo()
	{
		if (CountingDragonPrinceTime ==2) {
			//print (numInConvo);
			if (numInConvo >= ThistleAndDragonConvo0.Length)
				endDialogueTurn ();
			else
				makeConvo (ThistleAndDragonConvo0[numInConvo]);

		}

		else if (CountingDragonPrinceTime == 5) {
			//print (numInConvo);
			if (numInConvo >= ThistleAndDragonConvo1.Length)
				endDialogueTurn ();
			else
				makeConvo (ThistleAndDragonConvo1[numInConvo]);
		}

		else if (CountingDragonPrinceTime == 10) {
			//print (numInConvo);
			if (numInConvo >= ThistleAndDragonConvo2.Length)
				endDialogueTurn ();
			else
				makeConvo (ThistleAndDragonConvo2[numInConvo]);
		}

		else if (CountingDragonPrinceTime == 15) {
			//print (numInConvo);
			if (numInConvo >= ThistleAndDragonConvo3.Length)
				endDialogueTurn ();
			else
				makeConvo (ThistleAndDragonConvo3[numInConvo]);
		}

	}




	void makeConvo(string convoLine){

		//Debug.Log (convoLine);
		//Debug.Log (numInConvo);

		string[] Line = convoLine.Split (':');
		frontTalkPanel.SetActive(true);
		//printStringArray (Line);

		//Debug.Log (Line[0]);
		//Debug.Log(numInConvo+ " is apparantly not greater than " + Line.Length);
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
			//Debug.Log ("Changed PRINCE SPRITE");
			talkingPrince.GetComponent<Image>().sprite = characterSprite; //change to canvas
		}

		if (fullCharacterName == "Thyme" || fullCharacterName == "Matcha" || fullCharacterName == "Pepper") {
			 //Debug.Log ("Changed PRINCESSSSSSSSSSSS SPRITE");
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
		Debug.Log ("Clicked");
		numInConvo++;
			
	}

	void updateVariables(){

		if (ChrisStillOnMap==false && ThistleStillOnMap==false) {
			DarjeelingAlone = true;
		}
		if (DarjeelingStillOnMap==false && ThistleStillOnMap==false) {
			ChrisAlone = true;
		}
		if (ChrisStillOnMap==false && DarjeelingStillOnMap==false) {
			ThistleAlone = true;
		}


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

		if ((CountingDragonPrinceTime == 2 ||CountingDragonPrinceTime == 5 || CountingDragonPrinceTime == 10 ||CountingDragonPrinceTime == 15 ) && DarjeelingAlone && DarjeelingAndThymeMeet == false && DarjeelingAndMatchaMeet == false && DarjeelingAndPepperMeet == false) {
			DarjeelingAndDragonMeet = true;
		} else if (DarjeelingAlone && (CountingDragonPrinceTime == 2 ||CountingDragonPrinceTime == 5 || CountingDragonPrinceTime == 10 ||CountingDragonPrinceTime == 15 )&& (DarjeelingAndThymeMeet == true || DarjeelingAndMatchaMeet == true || DarjeelingAndPepperMeet == true)) {
			CountingDragonPrinceTime -= 1;
		}

		if ((CountingDragonPrinceTime == 2 ||CountingDragonPrinceTime == 5 || CountingDragonPrinceTime == 10 ||CountingDragonPrinceTime == 15 ) && ChrisAlone && ChrisAndThymeMeet == false && ChrisAndMatchaMeet == false && ChrisAndPepperMeet == false) {
			DarjeelingAndDragonMeet = true;
		} else if (ChrisAlone && (CountingDragonPrinceTime == 2 ||CountingDragonPrinceTime == 5 || CountingDragonPrinceTime == 10 ||CountingDragonPrinceTime == 15 ) &&  (ChrisAndThymeMeet == true || ChrisAndMatchaMeet == true || ChrisAndPepperMeet == true)) {
			CountingDragonPrinceTime -= 1;
		}

		if ((CountingDragonPrinceTime == 2 ||CountingDragonPrinceTime == 5 || CountingDragonPrinceTime == 10 ||CountingDragonPrinceTime == 15 ) && ThistleAlone && ThistleAndThymeMeet == false && ThistleAndMatchaMeet == false && ThistleAndPepperMeet == false) {
			ThistleAndDragonMeet = true;
		} else if (DarjeelingAlone && (CountingDragonPrinceTime == 2 ||CountingDragonPrinceTime == 5 || CountingDragonPrinceTime == 10 ||CountingDragonPrinceTime == 15 ) &&  (ThistleAndThymeMeet == true || ThistleAndMatchaMeet == true || ThistleAndPepperMeet == true)) {
			CountingDragonPrinceTime -= 1;
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
			//Debug.Log( stringArray[i] );
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
		else if (DarjeelingAndDragonMeet){
			CountingDragonPrinceTime++;
		}
		else if (ChrisAndDragonMeet){
			CountingDragonPrinceTime++;
		}
		else if (ThistleAndDragonMeet){
			CountingDragonPrinceTime++;
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
		DarjeelingAndDragonMeet = false;
		ChrisAndDragonMeet = false;
		ThistleAndDragonMeet = false;

		talkingPrince.GetComponent<SpriteRenderer> ().sprite = null;
		talkingPrincess.GetComponent<SpriteRenderer> ().sprite = null;
		talkingPrinceToDragon.GetComponent<SpriteRenderer> ().sprite = null;
		theText.text = null;
		personSpeaking.text = null;
		GameManager.GetComponent<TurnController> ().isPlayerTurn = 0;


	}


}
