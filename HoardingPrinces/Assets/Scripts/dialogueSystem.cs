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


	public Text theText;
	public GameObject talkingPrincess;
	public GameObject talkingPrince;
	public GameObject Prince_Mouth;
	public GameObject Princess_Mouth;

	public Sprite Thistle_normal;
	public Sprite Thistle_angry;

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
		
	}


	void makeDarjeelingThymeConvo()
	{

	}

	void makeConvo(string character, string emotion, string dialogue){



	}
}
