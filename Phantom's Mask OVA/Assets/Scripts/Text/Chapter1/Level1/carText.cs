using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Controls the Text script on the Car. Handles plyer interaction with the car
 * This script uses the following classes from Car:
 *          -CarMovement
 *          -CarCheckFix
 */ 
public class carText : MonoBehaviour {
    //The files the car will use
    //All private cosnts, these file names won't be changed nor used by other scripts
    private const string brokenCarAfterInspection_Caroline = "Broken Car (after inspection)-Caroline";
    private const string brokenCarAfterInspection_Yvette = "Broken Car (after inspection)-Yvette";
    private const string brokenCarBeforeInspection_Robbie = "Broken Car (before inspection)-Robbie";
    private const string brokenCarBeforeInspection_Yvette = "Broken Car (before inspection)-Yvette";
    private const string CarolineDetect_car = "CarolineDetect-Car";

    //Variables referenced from carCheckFix.cs on the Car GameObject that determines whether the Car has been fixed
    //Initialized to false, will be referenced in Start
    public bool carIsFixed = false;

    //Booleans that check whether the player is touching it for the first time or not
    //These bools will be manipulated based off who is touching the car and the situation
    private static bool CarolineTouch = false;
    private static bool RobbieTouch = false;
    private static bool YvetteTouch = false;


    // Use this for initialization
    void Start () {
        carIsFixed = gameObject.GetComponent<carCheckFix>().carIsFixed; //Make it reference the same spot
    }
	
	// Update is called once per frame
	void Update () {
		




	}

    private void OnTriggerEnter2D(Collider2D cplayer)
    {


    }

    private void OnTriggerExit2D(Collider2D cplayer)
    {


    }

}
