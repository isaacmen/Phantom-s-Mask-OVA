using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ch2Epilogue : MonoBehaviour {

	public GameObject caroline;
	public GameObject robbie;
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

		reader.GetComponent<ReadText> ().filename = "Chapter2-End(1).txt";
		reader.GetComponent<ReadText> ().active = true;
		yield return new WaitForSeconds(1);
		yield return new WaitWhile(() => txt.text != "");

		while(yvette.transform.position.x < 0) {
			yvette.transform.Translate (10 * Time.deltaTime, 0, 0);
			yield return new WaitForEndOfFrame();
		}

		while(robbie.transform.position.x < 1) {
			robbie.transform.Translate (10 * Time.deltaTime, 0, 0);
			caroline.transform.Translate (10 * Time.deltaTime, 0, 0);
			yield return new WaitForEndOfFrame();
		}

		reader.GetComponent<ReadText> ().filename = "Chapter2-End(2).txt";
		reader.GetComponent<ReadText> ().active = true;
		yield return new WaitForSeconds(1);
		yield return new WaitWhile(() => txt.text != "");

		while(yvette.transform.position.x < 6) {
			yvette.transform.Translate (10 * Time.deltaTime, 0, 0);
			yield return new WaitForEndOfFrame();
		}

		reader.GetComponent<ReadText> ().filename = "Chapter2-End(3).txt";
		reader.GetComponent<ReadText> ().active = true;
		yield return new WaitForSeconds(1);
		yield return new WaitWhile(() => txt.text != "");

		while(chris.transform.position.x < 10) {
			chris.transform.Translate (10 * Time.deltaTime, 0, 0);
			yield return new WaitForEndOfFrame();
		}

		reader.GetComponent<ReadText> ().filename = "Diary2(4).txt";
		reader.GetComponent<ReadText> ().active = true;
		yield return new WaitForSeconds(1);
		yield return new WaitWhile(() => txt.text != "");

		reader.GetComponent<ReadText> ().filename = "Diary2_Discussion(5).txt";
		reader.GetComponent<ReadText> ().active = true;
		yield return new WaitForSeconds(1);
		yield return new WaitWhile(() => txt.text != "");

		reader.GetComponent<ReadText> ().filename = "Power Outage(6).txt";
		reader.GetComponent<ReadText> ().active = true;
		yield return new WaitForSeconds(1);
		yield return new WaitWhile(() => txt.text != "");

		this.GetComponentInChildren<changeScene> ().active = true;

	}
}