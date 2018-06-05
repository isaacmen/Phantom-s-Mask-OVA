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

			while(robbie.transform.position.x < -4) {
				caroline.GetComponent<Animator>().SetInteger("Direction", 1);
				robbie.GetComponent<Animator>().SetInteger("Direction", 1);
				caroline.transform.Translate (5 * Time.deltaTime, 0, 0);
				robbie.transform.Translate (5 * Time.deltaTime, 0, 0);
				yield return new WaitForEndOfFrame();
			}
			caroline.GetComponent<Animator>().SetInteger("Direction", 0);
			robbie.GetComponent<Animator>().SetInteger("Direction", 0);

			yield return new WaitWhile(() => txt.text != "");

			reader.GetComponent<ReadText> ().filename = "Chapter2-Employee_lounge(2).txt";
			reader.GetComponent<ReadText> ().active = true;

			while(yvette.transform.position.x < -6) {
				yvette.GetComponent<Animator>().SetInteger("Direction", 1);
				yvette.transform.Translate (10 * Time.deltaTime, 0, 0);
				yield return new WaitForEndOfFrame();
			}
			yvette.GetComponent<Animator>().SetInteger("Direction", 0);
			yield return new WaitForSeconds(1);
			yield return new WaitWhile(() => txt.text != "");

		while(robbie.transform.position.x < 0) { 
				robbie.transform.Translate (5 * Time.deltaTime, 0, 0);
				robbie.GetComponent<Animator>().SetInteger("Direction", 1);
				yield return new WaitForEndOfFrame();
			}
			robbie.GetComponent<Animator>().SetInteger("Direction", 0);

			reader.GetComponent<ReadText>().active = true;
			reader.GetComponent<ReadText>().filename = "Diary 1 (3).txt";
			yield return new WaitForSeconds(1);
			yield return new WaitWhile(() => txt.text != "");

		while(caroline.transform.position.x < -1) {
				yvette.GetComponent<Animator>().SetInteger("Direction", 1);
				caroline.GetComponent<Animator>().SetInteger("Direction", 1);
				yvette.transform.Translate (5 * Time.deltaTime, 0, 0);
				caroline.transform.Translate (5 * Time.deltaTime, 0, 0);
				yield return new WaitForEndOfFrame();
			}
			caroline.GetComponent<Animator>().SetInteger("Direction", 0);
			yvette.GetComponent<Animator>().SetInteger("Direction", 0);

			reader.GetComponent<ReadText>().active = true;
			reader.GetComponent<ReadText>().filename = "Disscussion_After_Diary(4).txt";
			yield return new WaitForSeconds(1);
			yield return new WaitWhile(() => txt.text != "");

			while(robbie.transform.position.x > -10) {
				yvette.GetComponent<Animator>().SetInteger("Direction", 2);
				caroline.GetComponent<Animator>().SetInteger("Direction", 2);
				robbie.GetComponent<Animator>().SetInteger("Direction", 2);

				caroline.transform.Translate (-5 * Time.deltaTime, 0, 0);
				robbie.transform.Translate (-5 * Time.deltaTime, 0, 0);
				yvette.transform.Translate (-5 * Time.deltaTime, 0, 0);
				yield return new WaitForEndOfFrame();
			}

			this.GetComponentInChildren<changeScene> ().active = true;
		}
	}


