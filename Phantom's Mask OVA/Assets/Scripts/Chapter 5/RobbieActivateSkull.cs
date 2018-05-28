using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobbieActivateSkull : MonoBehaviour {
    //The skull controller. The sculls wil access its script.
    public GameObject skullController;
    //The skull number, used to find the text file. This script is shared by all the skulls
    public int skullNumber;
    //Robbie can activate the skulls
    private bool robbieTouching;
    // If skull is activated
    public bool skullActivated;

    private ArrayList touching;

    void Start () {
        robbieTouching = false;
        touching = new ArrayList();
    }
	
	// Update is called once per frame
	void Update () {
        if (skullActivated == false && Input.GetKey("e"))
        {
            string currentlyActive = GameObject.Find("controlPlayerActive").GetComponent<controlPlayerActive5people>().isActiveName();
            if (robbieTouching && (currentlyActive == "Robbie"))
            {
                //Make it glow
                GetComponent<SpriteRenderer>().enabled = true;
                //Communicate with the Skull Controller
                skullController.GetComponent<SkullController>().addArrayElement(skullNumber);
                skullActivated = true;
            }
            else if(touching.IndexOf(currentlyActive) > -1) //Read the name is it isn't Robbie
            {
                GameObject.Find("txtreader").GetComponent<ReadTextLvl5>().active = true;
                GameObject.Find("txtreader").GetComponent<ReadTextLvl5>().pathFolder = "Assets/Texts/Chapter 5/Level Text/";
                GameObject.Find("txtreader").GetComponent<ReadTextLvl5>().filename = "Skull " + skullNumber + ".txt";
            }
        }
	}


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Robbie")
            robbieTouching = true;
        else
            touching.Add(collision.name);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.name == "Robbie")
            robbieTouching = false;
        else
            touching.Remove(collision.name);
    }


}
