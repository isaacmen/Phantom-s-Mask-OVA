using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class treeText : MonoBehaviour {

    //Strings that have the file names
    private const string TreeCaroline = "Tree-Caroline.txt";
    private const string TreeRobbie = "Tree-Robbie.txt";

    //Checks if Robbie and Caroline have touched the box already and interacted with it
    private static bool robbieTouch = false;
    private static bool carolineTouch = false;

    //Checks if they are currently touching the box
    private bool carolineTouching = false;
    private bool robbieTouching = false;
    private bool yvetteTouching = false;

    // Update is called once per frame
    void Update()
    {
        if (robbieTouching && !robbieTouch && GameObject.Find("controlPlayerActive").GetComponent<controlPlayerActive>().isActiveName() == "Robbie" && Input.GetKey("e"))
        {
            gameObject.GetComponent<ReadText>().active = true;
            gameObject.GetComponent<ReadText>().filename = TreeRobbie;
            robbieTouch = true;
        }

        else if (carolineTouching && !carolineTouch && GameObject.Find("controlPlayerActive").GetComponent<controlPlayerActive>().isActiveName() == "Caroline" && Input.GetKey("e"))
        {
            gameObject.GetComponent<ReadText>().active = true;
            gameObject.GetComponent<ReadText>().filename = TreeCaroline;
            carolineTouch = true;
        }

        else if (yvetteTouching && Input.GetKey("e") && GameObject.Find("controlPlayerActive").GetComponent<controlPlayerActive>().isActiveName() == "Yvette")
        {
            gameObject.GetComponent<treeText>().enabled = false;
        }
    }

    void OnCollisionEnter2D(Collision2D player)
    {
        //Check if Caroline is touching the car
        if (player.gameObject.name == "Caroline")
            carolineTouching = true;

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
