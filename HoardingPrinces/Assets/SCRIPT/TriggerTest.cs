using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerTest : MonoBehaviour {


	// Use this for initialization
	void OnCollisionEnter2D (Collision2D col)
	{
		Debug.Log(gameObject.name + "Was collided by " + col.gameObject.name);
	}

	void OnTriggerEnter2D(Collider2D other) {

		Debug.Log(gameObject.name + "Was triggered by " + other.gameObject.name);
	}
}
