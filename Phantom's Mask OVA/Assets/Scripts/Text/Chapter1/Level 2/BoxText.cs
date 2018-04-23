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
		if (robbieTouching && GameObject.Find("Playercontroller").GetComponent<controlPlayerActive>().isActiveName() == "Robbie" && Input.GetKey("e"))
        {
            Debug.Log("dicks");

            reader.GetComponent<ReadText>().active = true;
            reader.GetComponent<ReadText>().filename = BoxRobbie;
        }
		
		else if (carolineTouching && GameObject.Find("Playercontroller").GetComponent<controlPlayerActive>().isActiveName() == "Caroline" && Input.GetKey("e"))
        {
            reader.GetComponent<ReadText>().active = true;
            reader.GetComponent<ReadText>().filename = BoxCaroline;
        }

        else if (yvetteTouching && Input.GetKey("e") && GameObject.Find("Playercontroller").GetComponent<controlPlayerActive>().isActiveName() == "Yvette")
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
            robbieTouching = true;
            //Debug.Log("fuck");
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
        else if (player.gameObject.name == "Robbie") { 
        robbieTouching = false;
            Debug.Log("shit");
        }

        //Check if Yvette is touching the box
        else if (player.gameObject.name == "Yvette")
            yvetteTouching = false;
    }
}
