using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ch2lvl2door : MonoBehaviour {

	public GameObject panel0;
	public GameObject panel1;
	public GameObject panel2;
	public GameObject panel3;

	private bool goodtogo = false;

	// Update is called once per frame
	void Update () {
		CheckPanels ();
	}

	void CheckPanels () {
		goodtogo = true;
		if (panel0.GetComponent<hiddenpanel> ().active == false) {
			goodtogo = false;
		}
		if (panel1.GetComponent<hiddenpanel> ().active == false) {
			goodtogo = false;
		}
		if (panel2.GetComponent<hiddenpanel> ().active == false) {
			goodtogo = false;
		}
		if (panel3.GetComponent<hiddenpanel> ().active == false) {
			goodtogo = false;
		}
	}

	private void OnTriggerStay2D(Collider2D player) {
		if (goodtogo && Input.GetKey ("e")) {
			this.GetComponentInChildren<changeScene>().active = true;
		}
	}
}
