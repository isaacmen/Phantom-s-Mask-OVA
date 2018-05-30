using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ch3Prologue : MonoBehaviour {

	public GameObject caroline;
	public GameObject yvette;
	public GameObject chris;
	public Text txt;

	private GameObject reader;

	// Use this for initialization
	void Start () {
		reader = GameObject.FindGameObjectWithTag("textbox");

		StartCoroutine(scene());
	}

	// Update is called once per frame
	void Update () {
	}

	IEnumerator scene() {

		while(yvette.transform.position.x < 0) {
			yvette.transform.Translate (10 * Time.deltaTime, 0, 0);
			chris.transform.Translate (10 * Time.deltaTime, 0, 0);
			caroline.transform.Translate (10 * Time.deltaTime, 0, 0);
			yield return new WaitForEndOfFrame();
		}

		reader.GetComponent<ReadText> ().filename = "Chapter 3 Prologue (1).txt";
		reader.GetComponent<ReadText> ().active = true;
		yield return new WaitForSeconds(1);
		yield return new WaitWhile(() => txt.text != "");

		while(yvette.transform.position.x < 15) {
			yvette.transform.Translate (10 * Time.deltaTime, 0, 0);
			chris.transform.Translate (10 * Time.deltaTime, 0, 0);
			caroline.transform.Translate (10 * Time.deltaTime, 0, 0);
			yield return new WaitForEndOfFrame();
		}

		this.GetComponentInChildren<changeScene> ().active = true;

	}
}
