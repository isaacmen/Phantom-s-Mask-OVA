using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trashcan : MonoBehaviour {

	public GameObject roofdoor;

	private bool carolineTouching = false;
	private bool robbieTouching = false;

	private GameObject reader;


	// Use this for initialization
	void Start () {
		reader = GameObject.FindGameObjectWithTag("textbox");
	}

	// Update is called once per frame
	void Update () {
		if (carolineTouching && Input.GetKey ("e")) {
			reader.GetComponent<ReadText>().active = true;
			reader.GetComponent<ReadText>().filename = "Trashcan Caroline.txt";
			roofdoor.GetComponent<RoofDoor>().hasCode = true;
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

