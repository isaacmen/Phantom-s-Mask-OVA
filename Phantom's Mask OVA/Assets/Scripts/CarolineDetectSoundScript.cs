using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * This one is ONLY For ControlPlayerActive with 3 characters. There will be a different one for levels where there are
 * More or less than 3 characters
 * */
public class CarolineDetectSoundScript : MonoBehaviour {
    public GameObject ControlPlayerActive;


	// Update is called once per frame
	void Update () {
        //Sound can play
		if(ControlPlayerActive.GetComponent<controlPlayerActive>().isActiveName() == "Caroline")
        {
            if(GetComponent<AudioSource>().enabled == false)
                 GetComponent<AudioSource>().enabled = true;
        }

        else
        {
            GetComponent<AudioSource>().enabled = false;
        }
	}
}
