using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ch1Prologue : MonoBehaviour {

	public Text txt;
	public bool moving;

	public AudioClip carsound;
	public AudioClip thud;
	public AudioClip carbreak;

	private GameObject reader;

	private AudioSource BGM;
	private AudioSource SFX;

	// Use this for initialization
	void Start () {
		reader = GameObject.FindGameObjectWithTag("textbox");
		BGM = GameObject.Find ("BGM").GetComponent<AudioSource> ();
		SFX = GameObject.Find ("SFX").GetComponent<AudioSource> ();

		moving = true;
		StartCoroutine(scene());
	}

	// Update is called once per frame
	void Update () {
	}

	IEnumerator scene() {

		reader.GetComponent<ReadText> ().active = true;
		reader.GetComponent<ReadText> ().filename = "Chapter 1 Prologue(1).txt";

		SFX.clip = carsound;
		SFX.Play ();
		yield return new WaitForSeconds(2);
		BGM.Play ();
		yield return new WaitWhile(() => txt.text != "");

		reader.GetComponent<ReadText> ().filename = "Chapter 1 Prologue(2).txt";
		reader.GetComponent<ReadText> ().active = true;

		SFX.clip = thud;
		SFX.Play ();
		BGM.Stop ();
		yield return new WaitForSeconds(1);
		yield return new WaitWhile(() => txt.text != "");

		reader.GetComponent<ReadText>().active = true;
		reader.GetComponent<ReadText>().filename = "Chapter 1 Prologue(3).txt";

		SFX.clip = carbreak;
		SFX.Play ();
		moving = false;
		yield return new WaitForSeconds(1);
		yield return new WaitWhile(() => txt.text != "");

		this.GetComponentInChildren<changeScene> ().active = true;
	}
}