using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonDeleteDoor : MonoBehaviour {
    public GameObject door; //Get the gameobject door this will control
    private bool doorDestroyed; //Keeps track if the door was already destroyed, is only used in this script(Static)
    private bool robbieTouching = false; //If Robbie is touching the object

	// Use this for initialization
	void Start()
    { 
        //Initialize the doorDestroyed to be false
        doorDestroyed = false;
    }
	
	// Update is called once per frame
	void Update () {

        if (doorDestroyed == false && robbieTouching)
        {
            //If it's Robbie and he's pressing e(special move)
            if (Input.GetKeyDown("e"))
            {
                Debug.Log(GameObject.Find("controlPlayerActive").GetComponent<controlPlayerActive>().isActiveName());
                //Check Robbie is in control by checking the controlPlayerActive isActiveName function which returns string name of object in control. 
                //Robbie must be active for This to work, prevents swapping to another char and pressing spacebar
                if (GameObject.Find("controlPlayerActive").GetComponent<controlPlayerActive>().isActiveName() == "Robbie")
                {
                    //Destroy the Door gameobject
                    Destroy(door);
                    doorDestroyed = true;
                }
            }
        }

    }

    void OnTriggerEnter2D(Collider2D player)
    {
        robbieTouching = true;
    }

    void OnTriggerExit2D(Collider2D player)
    {
        robbieTouching = false;
    }
}
