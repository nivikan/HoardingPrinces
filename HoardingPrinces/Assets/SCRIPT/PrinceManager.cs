using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Image=UnityEngine.UI.Image;
using UnityEngine.UI;

public class PrinceManager : MonoBehaviour {

	public GameObject Prince1;
	//public GameObject Prince2;
	//public GameObject Prince3;

	public GameObject Prince1_Location;
	//public GameObject Prince2_Location;
	//public GameObject Prince2_Location;

	public float Prince1_Happiness = 0.0f; 

	private Image Prince1_HappyBar;

	public int seconds = GameObject.Find ("GameManager").GetComponent<Keeping_Time>().seconds;


	// Use this for initialization
	void Start () {
		GameObject Prince1 =  GameObject.Find("Prince1");
		//GameObject Prince2 =  GameObject.Find("Prince2");
		//GameObject Prince3 =  GameObject.Find("Prince3");

		Prince1_HappyBar = GameObject.Find ("Prince1_Happybar").GetComponent<Image>();
		
	}
	
	// Update is called once per frame
	void Update () {
		seconds = GameObject.Find ("GameManager").GetComponent<Keeping_Time>().seconds;

		Prince1_Location = Prince1.GetComponent<Click_Drag>().currentCastle;
		//Prince2_Location = Prince2.GetComponent<Click_Drag>().currentCastle;
		//Prince3_Location = Prince3.GetComponent<Click_Drag>().currentCastle;

		Prince1_Happiness = (seconds*1.0f / 100)/5;
		Debug.Log (seconds*1.0 / 100);

		Prince1_HappyBar.fillAmount = Prince1_Happiness;
	}
}
