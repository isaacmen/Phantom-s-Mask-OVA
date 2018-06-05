using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itineraryText : MonoBehaviour {

	 //Strings that have the file names
    private const string itinerary= "Puzzle Diary Entry.txt";


    //Checks if they are currently touching the box
    private bool carolineTouching = false;
    private bool robbieTouching = false;
    private bool yvetteTouching = false;

    // Update is called once per frame
    void Update()
    {
        if (carolineTouching && GameObject.Find("controlPlayerActive").GetComponent<controlPlayerActive>().isActiveName() == "Caroline" && Input.GetKey("e"))
        {
            GameObject.Find("txtreader").GetComponent<ReadText>().active = true;
            GameObject.Find("txtreader").GetComponent<ReadText>().filename = itinerary;
        }
		else if (robbieTouching && GameObject.Find("controlPlayerActive").GetComponent<controlPlayerActive>().isActiveName() == "Robbie" && Input.GetKey("e"))
        {
            GameObject.Find("txtreader").GetComponent<ReadText>().active = true;
            GameObject.Find("txtreader").GetComponent<ReadText>().filename = itinerary;
        }
		if (yvetteTouching && GameObject.Find("controlPlayerActive").GetComponent<controlPlayerActive>().isActiveName() == "Yvette" && Input.GetKey("e"))
        {
            GameObject.Find("txtreader").GetComponent<ReadText>().active = true;
            GameObject.Find("txtreader").GetComponent<ReadText>().filename = itinerary;
        }
    }

    private void OnTriggerEnter2D(Collider2D player)
    {
        //Check if Caroline is touching the car
        if (player.name == "Caroline")
            carolineTouching = true;

        //Check if Robbie is touching the car
        else if (player.name == "Robbie")
            robbieTouching = true;

        else if (player.name == "Yvette")
            yvetteTouching = true;
    }

    private void OnTriggerExit2D(Collider2D player)
    {
        //Check if Caroline is touching the car
        if (player.name == "Caroline")
            carolineTouching = false;

        //Check if Robbie is touching the car
        else if (player.name == "Robbie")
            robbieTouching = false;

        //Check if Yvette is touching the car
        else if (player.name == "Yvette")
            yvetteTouching = false;
    }
}
