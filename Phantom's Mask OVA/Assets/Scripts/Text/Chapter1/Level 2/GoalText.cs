using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalText : MonoBehaviour {

	public GameObject gameend;

	private GameObject reader;
	private bool read;

	// Use this for initialization
	void Start () {
		reader = GameObject.FindGameObjectWithTag("textbox");
		read = false;
	}

	void Update() {
		if (read && reader.GetComponent<ReadText> ().active == false) {
			gameend.GetComponent<changeScene> ().active = true;
		}

	}
	
	void OnTriggerEnter2D(Collider2D player) {
		reader.GetComponent<ReadText> ().active = true;
		reader.GetComponent<ReadText> ().filename = "Goal.txt";

		read = true;
	}
}
