using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrologueCh2 : MonoBehaviour {

		public GameObject caroline;
		public GameObject robbie;
		public GameObject yvette;
		public Text txt;

		private GameObject reader;

		private bool part0 = true;
		private bool part1 = false;
		private bool part2 = false;
		private bool part3 = false;
		private bool part4 = false;

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
			reader.GetComponent<ReadText> ().filename = "Chapter2-Start(1).txt";

			for (int i = 0; i < 40; i++) {
				caroline.transform.Translate (10 * Time.deltaTime, 0, 0);
				robbie.transform.Translate (10 * Time.deltaTime, 0, 0);
				yield return new WaitForEndOfFrame();
			}
			yield return new WaitWhile(() => txt.text != "");

			reader.GetComponent<ReadText> ().filename = "Chapter2-Employee_lounge(2).txt";
			reader.GetComponent<ReadText> ().active = true;

			for (int i = 0; i < 45; i++) {
				yvette.transform.Translate (10 * Time.deltaTime, 0, 0);
				yield return new WaitForEndOfFrame();
			}
			yield return new WaitForSeconds(1);
			yield return new WaitWhile(() => txt.text != "");

			for (int i = 0; i < 50; i++) { 
				robbie.transform.Translate (10 * Time.deltaTime, 0, 0);
				yield return new WaitForEndOfFrame();
			}

			reader.GetComponent<ReadText>().active = true;
			reader.GetComponent<ReadText>().filename = "Diary 1 (3).txt";
			yield return new WaitForSeconds(1);
			yield return new WaitWhile(() => txt.text != "");

			for (int i = 0; i < 30; i++) {
				yvette.transform.Translate (10 * Time.deltaTime, 0, 0);
				caroline.transform.Translate (10 * Time.deltaTime, 0, 0);
				yield return new WaitForEndOfFrame();
			}

			reader.GetComponent<ReadText>().active = true;
			reader.GetComponent<ReadText>().filename = "Disscussion_After_Diary(4).txt";
			yield return new WaitForSeconds(1);
			yield return new WaitWhile(() => txt.text != "");

			for (int i = 0; i < 60; i++) {
				caroline.transform.Translate (10 * Time.deltaTime, 0, 0);
				robbie.transform.Translate (10 * Time.deltaTime, 0, 0);
				yvette.transform.Translate (10 * Time.deltaTime, 0, 0);
				yield return new WaitForEndOfFrame();
			}

			this.GetComponentInChildren<changeScene> ().active = true;
		}
	}


