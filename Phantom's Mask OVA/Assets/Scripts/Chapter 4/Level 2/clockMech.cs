using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clockMech : MonoBehaviour {
	private bool carolineTouching;
	private bool carolineTouched;
	private bool robbieTouching;
	public bool repaired;
	public couchCut cs;

	// Use this for initialization
	void Start () {
		repaired = false;
		carolineTouched = false;
		gameObject.GetComponent<Renderer>().enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (cs.broken == true && carolineTouched && Input.GetKeyDown("e") && robbieTouching){
			Debug.Log("yoyo");
			if (GameObject.Find("controlPlayerActive").GetComponent<controlPlayerActive>().isActiveName() == "Robbie"){
				repaired = true;
				Debug.Log("Activated");
			}
		}
		else if(Input.GetKeyDown("e") && carolineTouching){
			if (GameObject.Find("controlPlayerActive").GetComponent<controlPlayerActive>().isActiveName() == "Caroline")
            {
				carolineTouched = true;
				Debug.Log("caro touch");
			}
		}
	}
	
	private void OnTriggerEnter2D(Collider2D player)
    {
        if (player.name == "Caroline")
            carolineTouching = true;
		else if(player.name == "Robbie")
			robbieTouching = true;
    }

    private void OnTriggerExit2D(Collider2D player)
    {
        if (player.name == "Caroline")
            carolineTouching = false;
		else if(player.name == "Robbie")
			robbieTouching = false;
    }
}
