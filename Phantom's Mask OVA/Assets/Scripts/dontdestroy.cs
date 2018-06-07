using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dontdestroy : MonoBehaviour {

	private bool created = false;

	// Use this for initialization
	void Awake () {
		if (!created) {
			DontDestroyOnLoad (this.gameObject);
			created = true;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
