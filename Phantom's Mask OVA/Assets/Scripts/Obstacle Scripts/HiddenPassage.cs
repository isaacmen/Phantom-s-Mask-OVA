using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*  
 This class is meant for the "Hidden Passage" prefab involving 2 doors. This should be placed on the 1st door.
 The 2nd door will have a script called HiddenPassageDoor2 that will handle collisions with that door. This handles collisions with door 1.
 */
public class HiddenPassage : MonoBehaviour {

    //Door2 that pairs with Door1
    public GameObject door2;

    //Hide it from inspector
    private static bool isInvisible; //Whether the doors are invisible or not.

	// Use this for initialization
	void Start () {
        isInvisible = true;
        gameObject.GetComponent<Renderer>().enabled = false;
        //Disable render for the doors, makes them invisible
        door2.GetComponent<Renderer>().enabled = false;
    }
	
	// Update is called once per frame
	void Update () {
	}

    void OnTriggerStay2D(Collider2D player)
    {
        //If it's invisible and Veronica is touching it
        if (isInvisible == true && player.gameObject.name == "Caroline")
        {
            //If player is pressing spacebar
            if (Input.GetKeyDown("e"))
            {
                //Check Veronica is in control by checking the controlPlayerActive isActiveName function which returns string name of object in control. 
                if (GameObject.Find("controlPlayerActive").GetComponent<controlPlayerActive>().isActiveName() == "Caroline")
                {
                    //Make the doors appear
                    gameObject.GetComponent<Renderer>().enabled = true;
                    door2.GetComponent<Renderer>().enabled = true;
                    isInvisible = false;
                }
            }
        }

        //It's not invisible, anyone can use the door
        else
        { 
            //If player ispressing up key ont he door
            if (Input.GetKeyDown("w"))
            {
                //player is transported to door 2
                player.gameObject.transform.position = new Vector3(door2.transform.position.x, door2.transform.position.y, door2.transform.position.z);
            }
        }
    }
}
