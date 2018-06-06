using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class invisibleButtonLvl1 : MonoBehaviour {

    private bool isInvisible; //Whether the button is invisible or not.
    private bool carolineTouching;

    // Use this for initialization
    void Start () {
        isInvisible = true;
        gameObject.GetComponent<Renderer>().enabled = false;
        gameObject.GetComponent<buttonDeleteDoor>().enabled = false; 
        //Disable this script until the button isn't invisible

    }

    // Update is called once per frame
    void Update()
    {
        if (isInvisible == true)
        {
            if (Input.GetKeyDown("e") && carolineTouching)
            {
                //Check Caroline is in control by checking the controlPlayerActive isActiveName function which returns string name of object in control. 
                if (GameObject.Find("controlPlayerActive").GetComponent<controlPlayerActive>().isActiveName() == "Caroline")
                {
                    gameObject.GetComponent<Renderer>().enabled = true;
                    gameObject.GetComponent<buttonDeleteDoor>().enabled = true;
                    isInvisible = false;
                    gameObject.GetComponent<invisibleButtonLvl1>().enabled = false;
					GameObject.Find ("SFX").GetComponent<ch1lvl3SFX> ().ComputerSound ();
                }
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D player)
    {
        if (player.name == "Caroline")
            carolineTouching = true;
    }

    private void OnTriggerExit2D(Collider2D player)
    {
        if (player.name == "Caroline")
            carolineTouching = false;
    }

}
