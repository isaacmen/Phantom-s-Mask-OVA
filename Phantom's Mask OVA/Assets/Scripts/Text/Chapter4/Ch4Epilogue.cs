using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ch4Epilogue : MonoBehaviour {

	public GameObject yvette;
	public GameObject veronica;
	public Text txt;

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

		StartCoroutine(scene());
	}

	// Update is called once per frame
	void Update () {
	}

	IEnumerator scene() {

		reader.GetComponent<ReadText> ().filename = "Epilogue(1).txt";
		reader.GetComponent<ReadText> ().active = true;
		yield return new WaitForSeconds(1);
		yield return new WaitWhile(() => txt.text != "");

		reader.GetComponent<ReadText> ().filename = "Epilogue(2).txt";
		reader.GetComponent<ReadText> ().active = true;
		yield return new WaitForSeconds(1);
		yield return new WaitWhile(() => txt.text != "");

		while(veronica.transform.position.x < 0) {
			veronica.transform.Translate (10 * Time.deltaTime, 0, 0);
			yield return new WaitForEndOfFrame();
		}

		reader.GetComponent<ReadText> ().filename = "Epilogue(3).txt";
		reader.GetComponent<ReadText> ().active = true;
		yield return new WaitForSeconds(1);
		yield return new WaitWhile(() => txt.text != "");

		while(yvette.transform.position.x < -7) {
			yvette.transform.Translate (10 * Time.deltaTime, 0, 0);
			yield return new WaitForEndOfFrame();
		}

		reader.GetComponent<ReadText> ().filename = "Epilogue(4).txt";
		reader.GetComponent<ReadText> ().active = true;
		yield return new WaitForSeconds(1);
		yield return new WaitWhile(() => txt.text != "");

		this.GetComponentInChildren<changeScene> ().active = true;

	}
}
