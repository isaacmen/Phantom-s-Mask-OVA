using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow2P : MonoBehaviour {

	public GameObject caroline;
	public GameObject robbie;
	public GameObject controller;
	
	// Update is called once per frame
	void Update () {
		if (controller.GetComponent<controlPlayerActive2P> ().isActiveName() == "Robbie") {
			MoveCamera (robbie);
		} else if (controller.GetComponent<controlPlayerActive2P> ().isActiveName() == "Caroline") {
			MoveCamera (caroline);
		}
	}

	void MoveCamera (GameObject player) {
		float playerX = player.transform.position.x;
		if (playerX > -11 && playerX < 11) {
			this.transform.position = new Vector3 (playerX, 0.5f, -10.0f);
		} else if (playerX <= -11) {
			this.transform.position = new Vector3 (-11.0f, 0.5f, -10.0f);
		}else if (playerX >= 11) {
			this.transform.position = new Vector3 (11.0f, 0.5f, -10.0f);
		}
	}
}
