using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonDeleteDoor : MonoBehaviour {
    public GameObject door; //Get the gameobject door this will control
    private static bool doorDestroyed; //Keeps track if the door was already destroyed, is only used in this script(Static)

	// Use this for initialization
	void Start()
    { 
        //Initialize the doorDestroyed to be false
        doorDestroyed = false;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerStay2D(Collider2D player)
    {
        //Check the door hasn't been destroyed and if Robbie is touching it
        if (doorDestroyed == false && player.gameObject.name == "Robbie") 
        {
             //If it's Robbie and he's pressing Spacebar(special move)
             if (Input.GetKeyDown(KeyCode.Space))
             {
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
}
