using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rollercoaster : MonoBehaviour {

	public GameObject breakpoint1;
	public GameObject breakpoint2;
	public GameObject breakpoint3;
	public GameObject breakpoint4;

	public GameObject changescene;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (checkBP ()) {
			changescene.GetComponent<changeScene> ().active = true;
		}
	}

	bool checkBP() {
		if (!breakpoint1.GetComponent<breakPoint> ().broken) {
			return false;
		}
		if (!breakpoint2.GetComponent<breakPoint> ().broken) {
			return false;
		}
		if (!breakpoint3.GetComponent<breakPoint> ().broken) {
			return false;
		}
		if (!breakpoint4.GetComponent<breakPoint> ().broken) {
			return false;
		}
		return true;
	}
}
