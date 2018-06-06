using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class consoleText : MonoBehaviour {
    //Sound when Caroline detects the machine
    public GameObject carolineDetectSound;

    //PC turns on sprite
    public GameObject turnOn;
    //Turn on sound
    public GameObject turnOnSound;

	public string level = "Chapter2 Level3b";

	//Strings that have the file names
    private const string ConsoleCaroline = "CarolineMachineInteraction(Includes_Broken_Ferris_Wheel_Controller).txt";

    //Checks if Caroline have touched the box already and interacted with it
    private static bool carolineTouch = false;

    //Checks if they are currently touching the box
    private static bool carolineTouching = false;
    private static bool robbieTouching = false;
    private static bool yvetteTouching = false;
   
    
  

    // Update is called once per frame
    void Update()
    {
        if(carolineTouch)
            GetComponent<SpriteRenderer>().enabled = true;
        if (carolineTouching && !carolineTouch && GameObject.Find("controlPlayerActive").GetComponent<controlPlayerActive>().isActiveName() == "Caroline" && Input.GetKey("e"))
        {
            GameObject.Find("txtreader").GetComponent<ReadText>().active = true;
            GameObject.Find("txtreader").GetComponent<ReadText>().filename = ConsoleCaroline;
            //DESTROYS THE SOUND
            Destroy(carolineDetectSound);
            //Turn o the PC
            //turnOn.GetComponent<SpriteRenderer>().enabled = true;
            GetComponent<SpriteRenderer>().enabled = false;
            //Sound
            turnOnSound.GetComponent<AudioSource>().enabled = true;
            //Done
            carolineTouch = true;
        }
		else if (carolineTouch && robbieTouching && GameObject.Find("controlPlayerActive").GetComponent<controlPlayerActive>().isActiveName() == "Robbie" && Input.GetKey("e"))
        {

            SceneManager.LoadScene("Chapter2 Level3b");
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
