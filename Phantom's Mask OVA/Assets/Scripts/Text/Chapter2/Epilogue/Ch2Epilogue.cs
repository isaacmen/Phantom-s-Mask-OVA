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
	public Sprite newbg;

	public GameObject ball;
	public GameObject diary;
	public GameObject background;

	public AudioClip ballsound;
	public AudioClip diarysound;
	public AudioClip poweroutage;

	private AudioSource SFX;
	private GameObject reader;

	// Use this for initialization
	void Start () {
		reader = GameObject.FindGameObjectWithTag("textbox");
		SFX = GameObject.Find ("SFX").GetComponent<AudioSource> ();

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
			yvette.GetComponent<Animator>().SetInteger("Direction", 1);
			yvette.transform.Translate (10 * Time.deltaTime, 0, 0);
			yield return new WaitForEndOfFrame();
		}
		yvette.GetComponent<Animator>().SetInteger("Direction", 0);

		while(caroline.transform.position.x < -1) {
			robbie.GetComponent<Animator>().SetInteger("Direction", 1);
			caroline.GetComponent<Animator>().SetInteger("Direction", 1);
			robbie.transform.Translate (10 * Time.deltaTime, 0, 0);
			caroline.transform.Translate (10 * Time.deltaTime, 0, 0);
			yield return new WaitForEndOfFrame();
		}
		robbie.GetComponent<Animator>().SetInteger("Direction", 0);
		caroline.GetComponent<Animator>().SetInteger("Direction", 0);

		reader.GetComponent<ReadText> ().filename = "Chapter2-End(2).txt";
		reader.GetComponent<ReadText> ().active = true;
		yield return new WaitForSeconds(1);
		yield return new WaitWhile(() => txt.text != "");

		while(yvette.transform.position.x < 3.5) {
			yvette.GetComponent<Animator>().SetInteger("Direction", 1);
			yvette.transform.Translate (5 * Time.deltaTime, 0, 0);
			yield return new WaitForEndOfFrame();
		}
		yvette.GetComponent<Animator>().SetInteger("Direction", 0);

		ball.SetActive (false);
		SFX.clip = ballsound;
		SFX.Play ();
		yield return new WaitForSeconds(2);

		chris.transform.Rotate (0.0f, 0.0f, 90.0f);
		chris.transform.position = new Vector3 (2.5f, -2.5f, 0.0f);
		yvette.transform.localScale = new Vector3 (-0.75f, 0.75f, 0.75f);
		chris.GetComponent<Animator> ().enabled = true;

		reader.GetComponent<ReadText> ().filename = "Chapter2-End(3).txt";
		reader.GetComponent<ReadText> ().active = true;
		yield return new WaitForSeconds(1);
		yield return new WaitWhile(() => txt.text != "");

		diary.SetActive(true);
		SFX.clip = diarysound;
		SFX.Play ();

		reader.GetComponent<ReadText> ().filename = "Diary2(4).txt";
		reader.GetComponent<ReadText> ().active = true;
		yield return new WaitForSeconds(1);
		yield return new WaitWhile(() => txt.text != "");

		reader.GetComponent<ReadText> ().filename = "Diary2_Discussion(5).txt";
		reader.GetComponent<ReadText> ().active = true;
		yield return new WaitForSeconds(1);
		yield return new WaitWhile(() => txt.text != "");

		SFX.clip = poweroutage;
		SFX.Play ();
		background.GetComponent<SpriteRenderer> ().sprite = newbg;
		reader.GetComponent<ReadText> ().filename = "Power Outage(6).txt";
		reader.GetComponent<ReadText> ().active = true;
		yield return new WaitForSeconds(1);
		yield return new WaitWhile(() => txt.text != "");

		diary.SetActive(false);

		yvette.transform.localScale = new Vector3 (0.75f, 0.75f, 0.75f);
		chris.transform.localScale = new Vector3 (-0.75f, 0.75f, 0.75f);

		while(caroline.transform.position.x < 13) {
			robbie.GetComponent<Animator>().SetInteger("Direction", 2);
			caroline.GetComponent<Animator>().SetInteger("Direction", 1);
			chris.GetComponent<Animator>().SetInteger("Direction", 1);
			yvette.GetComponent<Animator>().SetInteger("Direction", 1);
			robbie.transform.Translate (-5 * Time.deltaTime, 0, 0);
			caroline.transform.Translate (5 * Time.deltaTime, 0, 0);
			yvette.transform.Translate (5 * Time.deltaTime, 0, 0);
			chris.transform.Translate (5 * Time.deltaTime, 0, 0);
			yield return new WaitForEndOfFrame();
		}

		this.GetComponentInChildren<changeScene> ().active = true;

	}
}