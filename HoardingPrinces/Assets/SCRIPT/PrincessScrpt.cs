using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrincessScrpt : MonoBehaviour {

	public GameObject PrincessWarning_Castle1;
	public GameObject PrincessWarning_Castle2;
	public GameObject PrincessWarning_Castle3;
	public GameObject PrincessWarning_Castle4;

	public float seconds; 

	public float princess1_Count = 0 ;
	public float princess2_Count = 0;
	public float princess3_Count = 0;

	private bool princess1_Coming = false;

	// Use this for initialization
	void Start () {
		seconds =  GameObject.Find ("GameManager").GetComponent<Keeping_Time>().seconds;
	}
	
	// Update is called once per frame
	void Update () {
		seconds =  GameObject.Find ("GameManager").GetComponent<Keeping_Time>().seconds;

		Debug.Log ((seconds/4)%1 == 0);
		
	}


	void updatePrincess1 () {
		//princess1_Count = 
		

	}



	void updatePrincess2 () {

	}


	void updatePrincess3 () {

	}


}
