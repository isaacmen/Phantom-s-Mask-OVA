using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class fenceLadderCheck : MonoBehaviour {

    //Set to true if the player smashes it with yvette, set to false if they choose Robbie
    private bool fenceIsBusted;

    // Use this for initialization
    void Start () {
        fenceIsBusted = true;
       //transform.gameObject.tag = null;
	}
	
	// Update is called once per frame
	void Update () {
        if(!fenceIsBusted) //If yvette didn't break it
        {
            transform.gameObject.tag = "ladder";
        }
	}

    public void setFenceIsBusted(bool t)
    {
        fenceIsBusted = t;
    }
	
	public bool checkFenceIsBusted(){
			return fenceIsBusted;
	}
}
