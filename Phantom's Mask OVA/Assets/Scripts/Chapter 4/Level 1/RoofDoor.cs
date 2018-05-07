using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoofDoor : MonoBehaviour {

	public bool hasCode = false;

	private bool carolineTouching = false;
	private bool robbieTouching = false;

	private GameObject reader;

	// Use this for initialization
	void Start () {
		reader = GameObject.FindGameObjectWithTag("textbox");
	}

	// Update is called once per frame
	void Update () {
		if (robbieTouching && Input.GetKey ("e") && !hasCode) {
			//reader.GetComponent<ReadText>().active = true;
			//reader.GetComponent<ReadText>().filename = "CarolinePanelInteraction.txt";
			Debug.Log("i cant get in");
		}

		if (robbieTouching && Input.GetKey ("e") && hasCode) {
			//reader.GetComponent<ReadText>().active = true;
			//reader.GetComponent<ReadText>().filename = "CarolinePanelInteraction.txt";
			Debug.Log("lemme turn this on");
			GetComponentInChildren<changeScene>().active = true;
		}
	}

	private void OnTriggerEnter2D(Collider2D player)
	{
		if (player.name == "Caroline") {
			carolineTouching = true;
		} else if (player.name == "Robbie") {
			robbieTouching = true;
		} 
	}

	private void OnTriggerExit2D(Collider2D player)
	{
		if (player.name == "Caroline") {
			carolineTouching = false;
		} else if (player.name == "Robbie") {
			robbieTouching = false;
		} 
	}
}
