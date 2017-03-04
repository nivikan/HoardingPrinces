using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrinceManager : MonoBehaviour {

	public GameObject Prince1;
	//public GameObject Prince2;
	//public GameObject Prince3;

	public GameObject Prince1_Location;
	//public GameObject Prince2_Location;
	//public GameObject Prince2_Location;


	// Use this for initialization
	void Start () {
		GameObject Prince1 =  GameObject.Find("Prince1");
		//GameObject Prince2 =  GameObject.Find("Prince2");
		//GameObject Prince3 =  GameObject.Find("Prince3");
		
	}
	
	// Update is called once per frame
	void Update () {
		Prince1_Location = Prince1.GetComponent<Click_Drag>().currentCastle;
		//Prince2_Location = Prince2.GetComponent<Click_Drag>().currentCastle;
		//Prince3_Location = Prince3.GetComponent<Click_Drag>().currentCastle;

		
	}
}
