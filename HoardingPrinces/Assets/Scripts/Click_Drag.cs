using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click_Drag : MonoBehaviour {

	public AudioClip myclip;

	private Vector3 screenPoint; 
	private Vector3 offset;


	public int isPlayerTurn= 0;

	public GameObject currentCastle;
	public GameObject GameManager;

	public GameObject prince1StartCastle; 
	public GameObject prince1EndCastle;


	// Use this for initialization
	void Start () {
		this.gameObject.AddComponent<AudioSource>();
		this.GetComponent<AudioSource>().clip = myclip;

		GameManager =  GameObject.Find ("GameManager");
		transform.position = new Vector3(currentCastle.transform.position.x, 2.5f, 0);

		
	}
	
	// Update is called once per frame
	void Update () {
		//Keep checking if it is player's turn
		isPlayerTurn = GameManager.GetComponent<TurnController>().isPlayerTurn;
		
	}

	void OnMouseDown()
	{
		//Debug.Log ("Clicked!");
		if (isPlayerTurn==0) {
			screenPoint = Camera.main.WorldToScreenPoint (transform.position);
			offset = transform.position - Camera.main.ScreenToWorldPoint (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
		}

		prince1StartCastle = currentCastle;


	}

	void OnMouseDrag()
	{
		if (isPlayerTurn==0) {
			Vector3 curScreenPoint = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
			Vector3 curPosition = Camera.main.ScreenToWorldPoint (curScreenPoint) + offset;
			transform.position = curPosition;
		}
	}

	void OnMouseUp()
	{
		if (isPlayerTurn==0) {

			if (doesPrinceExistInCastle ()) {
				transform.position = new Vector3(prince1StartCastle.transform.position.x,2.5f, 0);
			} else {
				transform.position = new Vector3(currentCastle.transform.position.x, 2.5f, 0);
				prince1StartCastle = currentCastle;
			}
			this.GetComponent<AudioSource>().Play();
		}

		
	}

	void OnTriggerEnter2D(Collider2D castle) {

		//Debug.Log(gameObject.name + " was triggered by " + castle.gameObject.name);
		currentCastle = castle.gameObject;
	}

	bool doesPrinceExistInCastle () 
	{
		GameObject Prince1Location = GameManager.GetComponent<PrinceManager>().Prince1_Location;
		GameObject Prince2Location = GameManager.GetComponent<PrinceManager>().Prince2_Location;
		GameObject Prince3Location = GameManager.GetComponent<PrinceManager>().Prince3_Location;

//		Debug.Log (Prince1Location + " and " +  Prince2Location + " and " + Prince3Location);

		if (currentCastle == Prince1Location) {
			return true;
		}
		else if (currentCastle == Prince2Location){
			return true;
		}
		else if (currentCastle == Prince3Location){
			return true;
		}


		return false;

	}
}



