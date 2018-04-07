using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class consoleText : MonoBehaviour {
	public string level = "Chapter2 Level3b";

	//Strings that have the file names
    private const string ConsoleCaroline = "CarolineMachineInteraction(Includes_Broken_Ferris_Wheel_Controller).txt";

    //Checks if Caroline have touched the box already and interacted with it
    private static bool carolineTouch = false;

    //Checks if they are currently touching the box
    private bool carolineTouching = false;
    private bool robbieTouching = false;
    private bool yvetteTouching = false;

    // Update is called once per frame
    void Update()
    {
        if (carolineTouching && !carolineTouch && GameObject.Find("controlPlayerActive").GetComponent<controlPlayerActive>().isActiveName() == "Caroline" && Input.GetKey("e"))
        {
            gameObject.GetComponent<ReadText>().active = true;
            gameObject.GetComponent<ReadText>().filename = ConsoleCaroline;
            carolineTouch = true;
        }
		else if (robbieTouching && GameObject.Find("controlPlayerActive").GetComponent<controlPlayerActive>().isActiveName() == "Robbie" && Input.GetKey("e"))
        {
            SceneManager.LoadScene ("Chapter2 Level3b");
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
