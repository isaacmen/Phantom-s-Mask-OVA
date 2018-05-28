using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirrorLever : MonoBehaviour {
    private bool leverIsTriggered;
    private bool robbieTouching;

	// Use this for initialization
	void Start () {
        leverIsTriggered = false;
        robbieTouching = false;
        
    }
	
    private void checkTriggerLever()
    {
        if(robbieTouching && Input.GetKey("e"))
        {
            if (GameObject.Find("controlPlayerActive").GetComponent<controlPlayerActive5people>().isActiveName() == "Robbie")
            {
                //Turn on the altar
                GameObject.Find("Altars").GetComponent<AltarController>().activateAltar(1);
                leverIsTriggered = false;
            }
        }

    }

	// Update is called once per frame
	void Update () {
        if (leverIsTriggered == false)
            checkTriggerLever();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.name == "Robbie")
        {
            robbieTouching = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.name == "Robbie")
        {
            robbieTouching = false;
        }
    }


}
