using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ch4Prologue : MonoBehaviour {

	public GameObject caroline;
	public GameObject robbie;
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

		reader.GetComponent<ReadText> ().filename = "Prologue.txt";
		reader.GetComponent<ReadText> ().active = true;
		yield return new WaitForSeconds(1);
		yield return new WaitWhile(() => txt.text != "");

		while(caroline.transform.position.x < -5) {
			caroline.transform.Translate (10 * Time.deltaTime, 0, 0);
			yield return new WaitForEndOfFrame();
		}

		reader.GetComponent<ReadText> ().filename = "Prologue 2.txt";
		reader.GetComponent<ReadText> ().active = true;
		yield return new WaitForSeconds(1);
		yield return new WaitWhile(() => txt.text != "");

		reader.GetComponent<ReadText> ().filename = "Prologue 3.txt";
		reader.GetComponent<ReadText> ().active = true;
		yield return new WaitForSeconds(1);
		yield return new WaitWhile(() => txt.text != "");

		this.GetComponentInChildren<changeScene> ().active = true;

	}
}
