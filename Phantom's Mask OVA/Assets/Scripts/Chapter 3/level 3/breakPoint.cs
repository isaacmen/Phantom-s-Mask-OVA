﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class breakPoint : MonoBehaviour {
	private bool isInvisible; //Whether the breakPoint is invisible or not.
    private bool carolineTouching;
	private bool yvetteTouching;
	public bool broken;

	// Use this for initialization
	void Start () {
		isInvisible = true;
		broken = false;
		gameObject.GetComponent<Renderer>().enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (isInvisible && Input.GetKeyDown("e") && carolineTouching){ //If Caroline detects it while invisible, show up
			if (GameObject.Find("controlPlayerActive").GetComponent<controlPlayerActive>().isActiveName() == "Caroline")
            {
			gameObject.GetComponent<Renderer>().enabled = true;
			isInvisible = false;
			}
			
		}
		else if (!isInvisible && Input.GetKeyDown("e") && yvetteTouching){ //Enables "break" if appears
			if (GameObject.Find("controlPlayerActive").GetComponent<controlPlayerActive>().isActiveName() == "Yvette")
            {
                    gameObject.GetComponent<SpriteRenderer>().color = Color.red;
					broken = true;
            }
		}
	}
	
	private void OnTriggerEnter2D(Collider2D player)
    {
        if (player.name == "Caroline")
            carolineTouching = true;
		else if(player.name == "Yvette")
			yvetteTouching = true;
    }

    private void OnTriggerExit2D(Collider2D player)
    {
        if (player.name == "Caroline")
            carolineTouching = false;
		else if(player.name == "Yvette")
			yvetteTouching = false;
    }
}
