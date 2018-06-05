using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
 * ATTATCHED TO CAR
 * Checks that Caroline and Robbie have interacted with the car. Disables carMovement script since
 * The car can't move since it's broken. Once Caroline interacts with it first then Robbie, the
 * Car can move and carMovement will be activated. carMovement will deactivate this script when 
 * it starts.
 */
public class carCheckFix : MonoBehaviour {
    public GameObject carolineDetectedCarSound;
    [HideInInspector]
    public bool carolineActivated = false;
    [HideInInspector]
    public bool robbieActivated = false;

 
    private bool carolineTouching = false;
    private bool robbieTouching = false;
    //Not used for this script, but used for other scripts
    private bool yvetteTouching = false;

    //This field will be used by the Text fields to see if the car has ben fixed
    [HideInInspector]
    public bool carIsFixed = false;

	// Use this for initialization
	void Start () {
        //Disable the carMovement script when this starts up
        gameObject.GetComponent<carMovement>().enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (!carIsFixed)
        {
            //if Caroline is touching the car, Caroline hasn't fixed the car, and caroline is active
            if (carolineTouching = true && carolineActivated == false && (GameObject.Find("controlPlayerActive").GetComponent<controlPlayerActive>().isActiveName() == "Caroline"))
                checkCarolineActivate();

            //If robbie is touchign the car and caroline found what's wrong with the car and robie is active
            else if (robbieTouching = true && carolineActivated == true && (GameObject.Find("controlPlayerActive").GetComponent<controlPlayerActive>().isActiveName() == "Robbie"))
                checkRobbieActivate();

            checkBothActivated();
        }
	}

    //checks if both are activated. if they are, enable carMovement script
    void checkBothActivated()
    {
        if (robbieActivated == true && carolineActivated == true)
        {
            gameObject.GetComponent<carMovement>().enabled = true;
            carIsFixed = true;
        }
    }

    //Makes Caroline activate the car
    void checkCarolineActivate()
    {
        //If caroline is pressing e
        if(Input.GetKeyDown("e"))
        {
            //Caroline checked what was wrong with the car
            carolineActivated = true;
            Destroy(carolineDetectedCarSound);
        }
    }

    //Makes Robbie check what is wrong with the car
    void checkRobbieActivate()
    {
        //if Robbie is pressing e
        if(Input.GetKeyDown("e"))
        {
            //Robbie checked what is wrong with the car
            robbieActivated = true;
        }

    }

    private void OnTriggerEnter2D(Collider2D player)
    {
        //Check if Caroline is touching the car
        if(player.name == "Caroline")
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
