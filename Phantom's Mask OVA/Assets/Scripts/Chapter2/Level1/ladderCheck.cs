using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ladderCheck : MonoBehaviour {

    //Set to true if the player smashes it with yvette, set to false if they choose Robbie
    private bool fenceIsBusted;

    // Use this for initialization
    void Start () {
        fenceIsBusted = false;
	}
	
	// Update is called once per frame
	void Update () {
        if(!fenceIsBusted) //If yvette didn't break it
        {
            //Enable ladder script
            //Disable this script
        }

		
	}

    public void setFenceIsBusted(bool t)
    {
        fenceIsBusted = t;
    }
}
