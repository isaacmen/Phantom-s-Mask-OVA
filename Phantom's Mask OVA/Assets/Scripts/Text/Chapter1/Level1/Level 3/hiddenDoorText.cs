using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hiddenDoorText : MonoBehaviour {

	 //Strings that have the file names
    private const string TextCaroline = "CarolineDebris.txt";
	private const string TextRobbie = "RobbieDebris.txt";


    //Checks if they are currently touching the box
    private bool carolineTouching = false;
    private bool robbieTouching = false;
    private bool yvetteTouching = false;

    // Update is called once per frame
    void Update()
    {
        if (robbieTouching && Input.GetKey("e") && GameObject.Find("controlPlayerActive").GetComponent<controlPlayerActive>().isActiveName() == "Robbie")
        {
            gameObject.GetComponent<ReadText>().active = true;
            gameObject.GetComponent<ReadText>().filename = TextRobbie;
        }

        else if (carolineTouching && GameObject.Find("controlPlayerActive").GetComponent<controlPlayerActive>().isActiveName() == "Caroline" && Input.GetKey("e"))
        {
            gameObject.GetComponent<ReadText>().active = true;
            gameObject.GetComponent<ReadText>().filename = TextCaroline;
        }

    }

    void OnCollisionEnter2D(Collision2D player)
    {
        //Check if Caroline is touching the car
        if (player.gameObject.name == "Caroline"){
            carolineTouching = true;
		}
        //Check if Robbie is touching the car
        else if (player.gameObject.name == "Robbie")
            robbieTouching = true;

        else if (player.gameObject.name == "Yvette")
            yvetteTouching = true;
    }

    private void OnCollisionExit2D(Collision2D player)
    {
        //Check if Caroline is touching the car
        if (player.gameObject.name == "Caroline")
            carolineTouching = false;

        //Check if Robbie is touching the car
        else if (player.gameObject.name == "Robbie")
            robbieTouching = false;

        //Check if Yvette is touching the car
        else if (player.gameObject.name == "Yvette")
            yvetteTouching = false;
    }
}
