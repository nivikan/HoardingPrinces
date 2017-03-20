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
			DarjeelingAndThymeConvo0 = (AllConvos[0].Split ('\n'));
			DarjeelingAndThymeConvo1 = (AllConvos[1].Split ('\n'));
			DarjeelingAndThymeConvo2 = (AllConvos[2].Split ('\n'));
			DarjeelingAndThymeConvo3 = (AllConvos[3].Split ('\n'));
		}
		if (DarjeelingAndMatcha != null) {
			string[] AllConvos = (DarjeelingAndMatcha.text.Split ('/'));
			DarjeelingAndMatchaConvo0 = (AllConvos[0].Split ('\n'));
			DarjeelingAndMatchaConvo1 = (AllConvos[1].Split ('\n'));
			DarjeelingAndMatchaConvo2 = (AllConvos[2].Split ('\n'));
			DarjeelingAndMatchaConvo3 = (AllConvos[3].Split ('\n'));
		}
		if (DarjeelingAndPepper != null) {
			string[] AllConvos = (DarjeelingAndPepper.text.Split ('/'));
			DarjeelingAndPepperConvo0 = (AllConvos[0].Split ('\n'));
			DarjeelingAndPepperConvo1 = (AllConvos[1].Split ('\n'));
			DarjeelingAndPepperConvo2 = (AllConvos[2].Split ('\n'));
			DarjeelingAndPepperConvo3 = (AllConvos[3].Split ('\n'));
		}



		//Prince Chris
		if (ChrisAndThyme != null) {
			string[] AllConvos = (ChrisAndThyme.text.Split ('/'));
			ChrisAndThymeConvo0 = (AllConvos[0].Split ('\n'));
			ChrisAndThymeConvo1 = (AllConvos[1].Split ('\n'));
			ChrisAndThymeConvo2 = (AllConvos[2].Split ('\n'));
			ChrisAndThymeConvo3 = (AllConvos[3].Split ('\n'));
		}
		if (ChrisAndMatcha != null) {
			string[] AllConvos = (ChrisAndMatcha.text.Split ('/'));
			ChrisAndMatchaConvo0 = (AllConvos[0].Split ('\n'));
			ChrisAndMatchaConvo1 = (AllConvos[1].Split ('\n'));
			ChrisAndMatchaConvo2 = (AllConvos[2].Split ('\n'));
			ChrisAndMatchaConvo3 = (AllConvos[3].Split ('\n'));
		}
		if (ChrisAndPepper != null) {
			string[] AllConvos = (ChrisAndPepper.text.Split ('/'));
			ChrisAndPepperConvo0 = (AllConvos[0].Split ('\n'));
			ChrisAndPepperConvo1 = (AllConvos[1].Split ('\n'));
			ChrisAndPepperConvo2 = (AllConvos[2].Split ('\n'));
			ChrisAndPepperConvo3 = (AllConvos[3].Split ('\n'));
		}



		//Prince Thistle
		if (ThistleAndThyme != null) {
			string[] AllConvos = (ThistleAndThyme.text.Split ('/'));
			ThistleAndThymeConvo0 = (AllConvos[0].Split ('\n'));
			ThistleAndThymeConvo1 = (AllConvos[1].Split ('\n'));
			ThistleAndThymeConvo2 = (AllConvos[2].Split ('\n'));
			ThistleAndThymeConvo3 = (AllConvos[3].Split ('\n'));
		}
		if (ThistleAndMatcha != null) {
			string[] AllConvos = (ThistleAndMatcha.text.Split ('/'));
			ThistleAndMatchaConvo0 = (AllConvos[0].Split ('\n'));
			ThistleAndMatchaConvo1 = (AllConvos[1].Split ('\n'));
			ThistleAndMatchaConvo2 = (AllConvos[2].Split ('\n'));
			ThistleAndMatchaConvo3 = (AllConvos[3].Split ('\n'));
		}
		if (ThistleAndPepper != null) {
			string[] AllConvos = (ThistleAndPepper.text.Split ('/'));
			ThistleAndPepperConvo0 = (AllConvos[0].Split ('\n'));
			ThistleAndPepperConvo1 = (AllConvos[1].Split ('\n'));
			ThistleAndPepperConvo2 = (AllConvos[2].Split ('\n'));
			ThistleAndPepperConvo3 = (AllConvos[3].Split ('\n'));
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
				makeDarjeelingThymeConvo ();
			}

			else if (DarjeelingAndMatchaMeet) {
				makeDarjeelingMatchaConvo ();
			}

			else if (DarjeelingAndPepperMeet) {
				makeDarjeelingPepperConvo ();
			}
		
			//CHRIS
			else if (ChrisAndThymeMeet) {
				makeChrisThymeConvo ();
			}

			else if (ChrisAndMatchaMeet) {
				makeChrisMatchaConvo ();
			}

			else if (ChrisAndPepperMeet) {
				makeChrisPepperConvo ();
			}

			//Thistle
			else if (ThistleAndThymeMeet) {
				makeThistleThymeConvo ();
			}

			else if (ThistleAndMatchaMeet) {
				makeThistleMatchaConvo ();
			}

			else if (ThistleAndPepperMeet) {
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
			makeConvo (DarjeelingAndThymeConvo0[numInConvo]);
		}

		else if (DarjeelingAndThymeEncounter == 1) {
			makeConvo (DarjeelingAndThymeConvo1[numInConvo]);
		}
		else if (DarjeelingAndThymeEncounter == 2) {
			makeConvo (DarjeelingAndThymeConvo2[numInConvo]);
		}
		else if (DarjeelingAndThymeEncounter == 3) {
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
			makeConvo (DarjeelingAndMatchaConvo0[numInConvo]);
		}

		else if (DarjeelingAndMatchaEncounter == 1) {
			makeConvo (DarjeelingAndMatchaConvo1[numInConvo]);
		}
		else if (DarjeelingAndMatchaEncounter == 2) {
			makeConvo (DarjeelingAndMatchaConvo2[numInConvo]);
		}
		else if (DarjeelingAndMatchaEncounter == 3) {
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
			makeConvo (DarjeelingAndPepperConvo0[numInConvo]);

		}

		else if (DarjeelingAndMatchaEncounter == 1) {
			makeConvo (DarjeelingAndPepperConvo1[numInConvo]);
		}
		else if (DarjeelingAndMatchaEncounter == 2) {
			makeConvo (DarjeelingAndPepperConvo2[numInConvo]);
		}
		else if (DarjeelingAndPepperEncounter == 3) {
			makeConvo (DarjeelingAndPepperConvo3[numInConvo]);
			DarjeelingAndThymeEncounter++;
			DarjeelingStillOnMap = false;
			PepperStillOnMap = false;
			frontTalkPanel.SetActive(false);
		}
	}

	void makeChrisThymeConvo()
	{
		if (ChrisAndThymeEncounter == 0) {
			makeConvo (ChrisAndThymeConvo0[numInConvo]);
		}

		else if (ChrisAndThymeEncounter == 1) {
			makeConvo (ChrisAndThymeConvo1[numInConvo]);
		}
		else if (ChrisAndThymeEncounter == 2) {
			makeConvo (ChrisAndThymeConvo2[numInConvo]);
		}
		else if (ChrisAndThymeEncounter == 3) {
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
			makeConvo (ChrisAndMatchaConvo0[numInConvo]);
		}

		else if (ChrisAndMatchaEncounter == 1) {
			makeConvo (ChrisAndMatchaConvo1[numInConvo]);
		}
		else if (ChrisAndMatchaEncounter == 2) {
			makeConvo (ChrisAndMatchaConvo2[numInConvo]);
		}
		else if (ChrisAndMatchaEncounter == 3) {
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
			makeConvo (ChrisAndPepperConvo0[numInConvo]);
		}

		else if (ChrisAndMatchaEncounter == 1) {
			makeConvo (ChrisAndPepperConvo1[numInConvo]);
		}
		else if (ChrisAndMatchaEncounter == 2) {
			makeConvo (ChrisAndPepperConvo2[numInConvo]);
		}
		else if (ChrisAndPepperEncounter == 3) {
			makeConvo (ChrisAndPepperConvo3[numInConvo]);
			ChrisAndThymeEncounter++;
			ChrisStillOnMap = false;
			PepperStillOnMap = false;
			frontTalkPanel.SetActive(false);
		}
	}


	void makeThistleThymeConvo()
	{
		if (ThistleAndThymeEncounter == 0) {
			makeConvo (ThistleAndThymeConvo0[numInConvo]);
		}

		else if (ThistleAndThymeEncounter == 1) {
			makeConvo (ThistleAndThymeConvo1[numInConvo]);
		}
		else if (ThistleAndThymeEncounter == 2) {
			makeConvo (ThistleAndThymeConvo2[numInConvo]);
		}
		else if (ThistleAndThymeEncounter == 3) {
			makeConvo (ThistleAndThymeConvo3[numInConvo]);
			ChrisAndThymeEncounter++;
			ChrisStillOnMap = false;
			ThymeStillOnMap = false;
			frontTalkPanel.SetActive(false);
		}
	}

	void makeThistleMatchaConvo()
	{
		if (ThistleAndMatchaEncounter == 0) {
			makeConvo (ThistleAndMatchaConvo0[numInConvo]);
		}

		else if (ThistleAndMatchaEncounter == 1) {
			makeConvo (ThistleAndMatchaConvo1[numInConvo]);
		}
		else if (ThistleAndMatchaEncounter == 2) {
			makeConvo (ThistleAndMatchaConvo2[numInConvo]);
		}
		else if (ThistleAndMatchaEncounter == 3) {
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
			makeConvo (ThistleAndPepperConvo0[numInConvo]);
		}

		else if (ThistleAndPepperEncounter == 1) {
			makeConvo (ThistleAndPepperConvo1[numInConvo]);
		}
		else if (ThistleAndPepperEncounter == 2) {
			makeConvo (ThistleAndPepperConvo2[numInConvo]);
		}
		else if (ThistleAndPepperEncounter == 3) {
			makeConvo (ThistleAndPepperConvo3[numInConvo]);
			ThistleAndThymeEncounter++;
			ThistleStillOnMap = false;
			PepperStillOnMap = false;
			frontTalkPanel.SetActive(false);
		}
	}





	void makeConvo(string convoLine){

		//Debug.Log (convoLine);

		string[] Line = convoLine.Split (':');
		frontTalkPanel.SetActive(true);

		//Debug.Log (Line[0]);

		if (numInConvo + 1 > Line.Length) {

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

		} else {
			makeDialogue (Line [0], Line [1], Line [2]);
		}
	

	}

	void makeDialogue(string character, string emotion, string dialogue){

		string fullCharacterName = getCharacter (character);
		Debug.Log (fullCharacterName);
		Sprite characterSprite = getSprite(fullCharacterName,emotion);

		if (fullCharacterName == "Darjeeling" || fullCharacterName == "Chris" || fullCharacterName == "Thistle") {
			talkingPrince.GetComponent<SpriteRenderer> ().sprite = characterSprite;
		}

		if (fullCharacterName == "Thyme" || fullCharacterName == "Matcha" || fullCharacterName == "Pepper") {
			talkingPrincess.GetComponent<SpriteRenderer> ().sprite = characterSprite;
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


}
