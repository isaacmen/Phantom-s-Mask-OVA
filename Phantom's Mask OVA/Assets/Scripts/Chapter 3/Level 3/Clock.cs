using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour {

	public GameObject dropper;
	private bool touch = false;


	void Update() {
		if (touch && Input.GetKey ("e")) {
			GameObject.Destroy (dropper);
		}
	}

	void OnTriggerEnter2D (Collider2D other) {
		if (other.gameObject.tag == "character") {
			touch = true;
		}
	}

	void OnTriggerExit2D (Collider2D other) {
		if (other.gameObject.tag == "character") {
			touch = false;
		}
	}

}
