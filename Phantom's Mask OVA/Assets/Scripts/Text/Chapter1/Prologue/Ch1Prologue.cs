using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ch1Prologue : MonoBehaviour {

	public Text txt;

	private GameObject reader;

	private int timer = 0;

	// Use this for initialization
	void Start () {
		reader = GameObject.FindGameObjectWithTag("textbox");

		StartCoroutine(scene());
	}

	// Update is called once per frame
	void Update () {
	}

	IEnumerator scene() {

		reader.GetComponent<ReadText> ().active = true;
		reader.GetComponent<ReadText> ().filename = "Chapter 1 Prologue(1).txt";

		yield return new WaitWhile(() => txt.text != "");

		reader.GetComponent<ReadText> ().filename = "Chapter 1 Prologue(2).txt";
		reader.GetComponent<ReadText> ().active = true;

		yield return new WaitForSeconds(1);
		yield return new WaitWhile(() => txt.text != "");

		reader.GetComponent<ReadText>().active = true;
		reader.GetComponent<ReadText>().filename = "Chapter 1 Prologue(3).txt";

		yield return new WaitForSeconds(1);
		yield return new WaitWhile(() => txt.text != "");

		this.GetComponentInChildren<changeScene> ().active = true;
	}
}
