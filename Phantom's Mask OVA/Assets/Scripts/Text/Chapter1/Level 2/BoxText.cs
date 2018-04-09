using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Controls the Text script on the Breakable Box. Handles plyer interaction with the box
 */ 
public class BoxText : MonoBehaviour {
	
	//Strings that have the file names
    private const string BoxCaroline = "Box-Caroline.txt";
    private const string BoxRobbie = "Box-Robbie.txt";
	
	//Checks if Robbie and Caroline have touched the box already and interacted with it
    private static bool robbieTouch = false;
    private static bool carolineTouch = false;
	
	//Checks if they are currently touching the box
    private bool carolineTouching = false;
    private bool robbieTouching = false;
    private bool yvetteTouching = false;

    //Textbox to read to
    private GameObject reader;

    void Start()
    {
        reader = GameObject.FindGameObjectWithTag("textbox");
    }

    // Update is called once per frame
    void Update () {
		if (robbieTouching && !robbieTouch && GameObject.Find("controlPlayerActive").GetComponent<controlPlayerActive>().isActiveName() == "Robbie" && Input.GetKey("e"))
        {
            reader.GetComponent<ReadText>().active = true;
            reader.GetComponent<ReadText>().filename = BoxRobbie;
            robbieTouch = true;
        }
		
		else if (carolineTouching && !carolineTouch && GameObject.Find("controlPlayerActive").GetComponent<controlPlayerActive>().isActiveName() == "Caroline" && Input.GetKey("e"))
        {
            reader.GetComponent<ReadText>().active = true;
            reader.GetComponent<ReadText>().filename = BoxCaroline;
            carolineTouch = true;
        }

        else if (yvetteTouching && Input.GetKey("e") && GameObject.Find("controlPlayerActive").GetComponent<controlPlayerActive>().isActiveName() == "Yvette")
        {
            gameObject.GetComponent<BoxText>().enabled = false;
        }
	}
	
	void OnCollisionEnter2D(Collision2D player)
    {
        //Check if Caroline is touching the box
        if (player.gameObject.name == "Caroline")
            carolineTouching = true;

        //Check if Robbie is touching the box
        else if (player.gameObject.name == "Robbie"){
			gameObject.GetComponent<ReadText>().filename = BoxRobbie;
            robbieTouching = true;
			
		}

        else if (player.gameObject.name == "Yvette")
            yvetteTouching = true;
    }
	
	private void OnCollisionExit2D(Collision2D player)
    {
        //Check if Caroline is touching the box
        if (player.gameObject.name == "Caroline")
            carolineTouching = false;

        //Check if Robbie is touching the box
        else if (player.gameObject.name == "Robbie")
            robbieTouching = false;

        //Check if Yvette is touching the box
        else if (player.gameObject.name == "Yvette")
            yvetteTouching = false;
    }
}
