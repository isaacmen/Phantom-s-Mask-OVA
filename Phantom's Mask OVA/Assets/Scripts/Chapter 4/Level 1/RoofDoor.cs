using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoofDoor : MonoBehaviour {

	public bool hasCode = false;

	private bool touching = false;
	private bool moveon = false;

	private GameObject reader;

	// Use this for initialization
	void Start () {
		reader = GameObject.FindGameObjectWithTag("textbox");
	}

	// Update is called once per frame
	void Update () {
		if (touching && Input.GetKey ("e") && !hasCode) {
			reader.GetComponent<ReadText>().active = true;
			reader.GetComponent<ReadText>().filename = "Roofdoor without code.txt";
		}

		if (touching && Input.GetKey ("e") && hasCode) {
			reader.GetComponent<ReadText>().active = true;
			reader.GetComponent<ReadText>().filename = "Roofdoor with code.txt";

			moveon = true;
		}

		if (moveon && reader.GetComponent<ReadText>().active == false) {
			GetComponentInChildren<changeScene>().active = true;
		}
	}

	private void OnTriggerEnter2D(Collider2D player)
	{
		touching = true;
	}

	private void OnTriggerExit2D(Collider2D player)
	{
		touching = false;
	}
}
