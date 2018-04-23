using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lvl3Diary : MonoBehaviour {

	private GameObject reader;
	private bool carolineTouching;

	// Use this for initialization
	void Start () {
		reader = GameObject.FindGameObjectWithTag("textbox");
	}
	
	// Update is called once per frame
	void Update () {
		if (carolineTouching && Input.GetKey ("e")) {
			reader.GetComponent<ReadText>().active = true;
			reader.GetComponent<ReadText>().filename = "tempdiary.txt";
		}
	}


	private void OnTriggerEnter2D(Collider2D player)
	{
		if (player.name == "Caroline") {
			carolineTouching = true;
		}
	}

	private void OnTriggerExit2D(Collider2D player)
	{
		if (player.name == "Caroline") {
			carolineTouching = false;
		} 
	}
}
