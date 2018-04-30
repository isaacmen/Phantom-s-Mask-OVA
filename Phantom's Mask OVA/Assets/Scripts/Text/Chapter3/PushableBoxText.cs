using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushableBoxText : MonoBehaviour {

	//Strings that have the file names
    private const string TextCaroline = "MovingBoxes_Caroline.txt";
    private const string TextYvette = "MovingBoxes_Yvette.txt";

    //Checks if they are currently touching the box
    private bool carolineTouching = false;
    private bool yvetteTouching = false;

    // Update is called once per frame
    void Update()
    {
        if (carolineTouching && GameObject.Find("controlPlayerActive").GetComponent<controlPlayerActive>().isActiveName() == "Caroline" && Input.GetKey("e"))
        {
            gameObject.GetComponent<ReadText>().active = true;
            gameObject.GetComponent<ReadText>().filename = TextCaroline;
        }

        else if (yvetteTouching && Input.GetKey("e") && GameObject.Find("controlPlayerActive").GetComponent<controlPlayerActive>().isActiveName() == "Yvette")
        {
            gameObject.GetComponent<ReadText>().active = true;
            gameObject.GetComponent<ReadText>().filename = TextYvette;
        }
    }

    void OnCollisionEnter2D(Collision2D player)
    {
        //Check if Caroline is touching the car
        if (player.gameObject.name == "Caroline")
            carolineTouching = true;

        else if (player.gameObject.name == "Yvette")
            yvetteTouching = true;
    }

    private void OnCollisionExit2D(Collision2D player)
    {
        //Check if Caroline is touching the car
        if (player.gameObject.name == "Caroline")
            carolineTouching = false;

        //Check if Yvette is touching the car
        else if (player.gameObject.name == "Yvette")
            yvetteTouching = false;
    }
}
