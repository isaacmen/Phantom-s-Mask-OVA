using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tempending : MonoBehaviour {

	private int timer = 0;
	private bool canchange;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		timer++;
		if (timer>30) {
			canchange = true;
		}

		if (Input.GetKey (KeyCode.Space)) {
			GameObject.Destroy (GameObject.Find ("bgm"));
			SceneManager.LoadScene ("Title Screen");
		}
	}
}
