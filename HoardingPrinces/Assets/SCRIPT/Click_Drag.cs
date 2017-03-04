using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click_Drag : MonoBehaviour {

	private Vector3 screenPoint; 
	private Vector3 offset;

	public GameObject currentCastle;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown()
	{
		screenPoint = Camera.main.WorldToScreenPoint(transform.position);
		offset =  transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y,screenPoint.z));
	}

	void OnMouseDrag()
	{
		Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
		Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
		transform.position = curPosition;
	}

	void OnMouseUp()
	{
		transform.position = currentCastle.transform.position;
	}

	void OnTriggerEnter2D(Collider2D castle) {

		Debug.Log(gameObject.name + " was triggered by " + castle.gameObject.name);
		currentCastle = castle.gameObject;
	}
}
