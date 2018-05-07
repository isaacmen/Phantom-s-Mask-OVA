using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightOn : MonoBehaviour {
	public clockMech clock;
	public bool on;

	// Use this for initialization
	void Start () {
			on = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (clock.repaired){
			gameObject.GetComponent<Renderer>().enabled = false;
			on = true;
		}
	}
}
