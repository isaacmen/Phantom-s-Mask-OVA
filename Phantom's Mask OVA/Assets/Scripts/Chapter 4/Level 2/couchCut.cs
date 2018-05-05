using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class couchCut : MonoBehaviour {
	
	private bool isInvisible; //Whether the breakPoint is invisible or not.
	private bool veronicaTouching;
	public bool broken;
	
	// Use this for initialization
	void Start () {
		isInvisible = true;
		broken = false;
		gameObject.GetComponent<Renderer>().enabled = false;	
	}
	
	// Update is called once per frame
	void Update () {
		if (isInvisible && Input.GetKeyDown("e") && veronicaTouching){ //If Caroline detects it while invisible, show up
			if (GameObject.Find("controlPlayerActive").GetComponent<controlPlayerActive>().isActiveName() == "Veronica")
            {
			gameObject.GetComponent<Renderer>().enabled = true;
			isInvisible = false;
			}
			
		}
	}
	
	
	private void OnTriggerEnter2D(Collider2D player)
    {
        if (player.name == "Veronica")
            veronicaTouching = true;
    }

    private void OnTriggerExit2D(Collider2D player)
    {
        if (player.name == "Veronica")
            veronicaTouching = false;

    }
}
