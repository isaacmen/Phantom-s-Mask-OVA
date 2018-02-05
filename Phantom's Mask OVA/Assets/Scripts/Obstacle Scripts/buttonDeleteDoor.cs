using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonDeleteDoor : MonoBehaviour {
    public GameObject door; //Get the gameobject door this will control
    private static bool doorDestroyed = false; //Keeps track if the door was already destroyed

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerStay2D(Collider2D player)
    {
        //Debug.Log(player.gameObject.name + "\n");
        //Check the door hasn't been destroyed and if Robbie is touching it
        if(doorDestroyed == false && player.gameObject.name == "Robbie") 
        {
            //If it's Robbie and he's pressing Spacebar(special move)
            if(Input.GetKeyDown(KeyCode.Space))
            {
                //Destroy the Door gameobject
                Destroy(door);
                //Debug.Log("Door was Destroyed\n");
                doorDestroyed = true;
            }
        }
    }
}
