﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeScene : MonoBehaviour {

	public bool active;
	public string level;

	// Use this for initialization
	void Start () {
		active = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (active) {
			SceneManager.LoadScene (level);
		}
		if (Input.GetKeyDown("space")){
			active = true;
		}
	}
}
