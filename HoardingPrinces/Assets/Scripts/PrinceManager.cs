using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Image=UnityEngine.UI.Image;
using UnityEngine.UI;

public class PrinceManager : MonoBehaviour {


	public GameObject Prince1;
	public GameObject Prince2;
	public GameObject Prince3;

	public GameObject Prince1_Location;
	public GameObject Prince2_Location;
	public GameObject Prince3_Location;

	public float Prince1_Happiness = 0.0f; 
	public float Prince2_Happiness = 0.0f; 
	public float Prince3_Happiness = 0.0f; 

	//private Image Prince1_HappyBar;
	//private Image Prince2_HappyBar;
	//private Image Prince3_HappyBar;


	//Keep track of time
	public int seconds = 0;


	// Use this for initialization
	void Start () {
		GameObject Prince1 =  GameObject.Find("Prince1");
		GameObject Prince2 =  GameObject.Find("Prince2");
		GameObject Prince3 =  GameObject.Find("Prince3");

		//Prince1_HappyBar = GameObject.Find ("Prince1_Happybar").GetComponent<Image>();
		//Prince2_HappyBar = GameObject.Find ("Prince2_Happybar").GetComponent<Image>();
		//Prince3_HappyBar = GameObject.Find ("Prince3_Happybar").GetComponent<Image>();
		
	}
	
	// Update is called once per frame
	void Update () {
		seconds = GameObject.Find ("GameManager").GetComponent<Keeping_Time>().seconds;

		if (Prince1 == null) {
			//Debug.Log ("Darjeeling is gone");
			Prince1_Location = null;
		} else {
			Prince1_Location = Prince1.GetComponent<Click_Drag>().prince1StartCastle;
		}
		if (Prince2 == null) {
			//Debug.Log ("Chris is gone");
			Prince2_Location = null;
		}else {
			Prince2_Location = Prince2.GetComponent<Click_Drag>().prince1StartCastle;
		}
		if (Prince3 == null) {
			//Debug.Log ("Darjeeling is gone");
			Prince3_Location = null;
		}else {
			Prince3_Location = Prince3.GetComponent<Click_Drag>().prince1StartCastle;
		}
		//Prince1_Happiness = (seconds*1.0f / 100)/10;
		//Prince2_Happiness = (seconds*1.0f / 100)/10;
		//Prince3_Happiness = (seconds*1.0f / 100)/10;

		//Prince1_HappyBar.fillAmount = Prince1_Happiness;
		//Prince2_HappyBar.fillAmount = Prince2_Happiness;
		//Prince3_HappyBar.fillAmount = Prince3_Happiness;
	}
}
