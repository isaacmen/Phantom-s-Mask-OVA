using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveBG : MonoBehaviour {

	public GameObject cutscene;

	void Update () {
		if (cutscene.GetComponent<Ch1Prologue> ().moving) {
			this.transform.Translate (-1.75f * Time.deltaTime, 0, 0);
		}

		if (this.transform.position.x <= 0.0f && 
			this.transform.position.x >= -0.05f){
			Instantiate (this.gameObject, 
				new Vector3 (19.87f, 0.0f, this.transform.position.z - 0.01f), this.transform.rotation);
		}
		if (this.transform.position.x <= -20.0f) {
			Destroy (this.gameObject);
		}
	}
}
