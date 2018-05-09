using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FakeTree : MonoBehaviour {

	public GameObject ladder;

	private bool carolineTouching = false;
	private bool robbieTouching = false;

	private bool carolineTouched = false;

	private GameObject reader;

	// Use this for initialization
	void Start () {
		reader = GameObject.FindGameObjectWithTag("textbox");
	}
	
	// Update is called once per frame
	void Update () {

		if (robbieTouching && Input.GetKey ("e") && !carolineTouched) {
			reader.GetComponent<ReadText>().active = true;
			reader.GetComponent<ReadText>().filename = "Robbie Tree (not mechanical).txt";
		}

		if (carolineTouching && Input.GetKey ("e") && !carolineTouched) {
			reader.GetComponent<ReadText>().active = true;
			reader.GetComponent<ReadText>().filename = "Caroline Tree.txt";
			carolineTouched = true;
		}

		if (robbieTouching && Input.GetKey ("e") && carolineTouched) {
			reader.GetComponent<ReadText>().active = true;
			reader.GetComponent<ReadText>().filename = "Robbie Tree (mechanical).txt";
			carolineTouched = true;
			ladder.SetActive(true);
		}
	}

	private void OnTriggerEnter2D(Collider2D player)
	{
		if (player.name == "Caroline") {
			carolineTouching = true;
			robbieTouching = false;
		} else if (player.name == "Robbie") {
			robbieTouching = true;
			carolineTouching = false;
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
