using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Dialogue_LastDragonScene : MonoBehaviour {

	public Sprite surprise;
	public Sprite blush;
	public Sprite blush2;
	public Sprite currPrinceSprite;
	public GameObject talkingPrince;
	public GameObject TheEnd;
	public GameObject princeDragonCG;
	public Text theText;


	public int numInConvo;
	public int numInConvoWhereDragonTransform;

	public TextAsset PrinceAndDragon;
	public string[] Convo;

	// Use this for initialization
	void Start () {
		if (PrinceAndDragon != null) {
			Convo = getRidOfBlankArray(PrinceAndDragon.text.Split ('\n'));
		}


	}
	
	// Update is called once per frame
	void Update () {

		currPrinceSprite = blush;
		talkingPrince.SetActive (true);

		talkingPrince.GetComponent<Image>().sprite = currPrinceSprite;

		if (numInConvo == Convo.Length+1) {
			SceneManager.LoadScene("Start");
		}

		if (numInConvo == numInConvoWhereDragonTransform) {
			talkingPrince.GetComponent<Animator>().Play("FlashAnim_EndScene");
		}

		if (numInConvo >= numInConvoWhereDragonTransform) {
			princeDragonCG.SetActive (false);
		}
		if (numInConvo >= Convo.Length) {
			Debug.Log ("END");
			TheEnd.SetActive (true);
			TheEnd.GetComponent<Animator>().Play("TheEnd_FadeIn");
		}
			
		else {
			makeConvo (Convo [numInConvo]);
		}


	}
		



	void makeConvo(string convoLine){
		string[] Line = convoLine.Split (':');

		//Debug.Log (Line [0] + Line [1] );

		makeDialogue (Line [0], Line [1]);
	


	}

	void makeDialogue(string emotion, string dialogue){

		Sprite characterSprite = getSprite(emotion); //change to canvas

		//Debug.Log (dialogue);
		talkingPrince.GetComponent<Image>().sprite = characterSprite; //change to canvas

		theText.text = dialogue;

	}



	Sprite getSprite(string emotion){
		Debug.Log (emotion);
		if (emotion == "blush" || emotion == " blush" )
				return blush;
		else if (emotion == "blush2" || emotion == " blush2" )
				return blush2;
		else if (emotion == "surprise" || emotion == "surprise" )
				return surprise;
			else 
				return blush2; 
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

	public void nextLine(){
		numInConvo++;
	}

}
