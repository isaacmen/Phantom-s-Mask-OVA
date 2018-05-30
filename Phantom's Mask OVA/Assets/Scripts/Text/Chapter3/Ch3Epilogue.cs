using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ch3Epilogue : MonoBehaviour {

	public GameObject cart;
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

		reader.GetComponent<ReadText> ().filename = "Level 3 End.txt";
		reader.GetComponent<ReadText> ().active = true;
		yield return new WaitForSeconds(1);
		yield return new WaitWhile(() => txt.text != "");

		while(cart.transform.position.y < 10) {
			cart.transform.Translate (0, 20 * Time.deltaTime, 0);
			yield return new WaitForEndOfFrame();
		}

		reader.GetComponent<ReadText> ().filename = "Level 3 End (2).txt";
		reader.GetComponent<ReadText> ().active = true;
		yield return new WaitForSeconds(1);
		yield return new WaitWhile(() => txt.text != "");

		this.GetComponentInChildren<changeScene> ().active = true;

	}
}
