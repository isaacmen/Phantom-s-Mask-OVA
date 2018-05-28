using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Controlls all the Skulls. Al the Skulls report to this script to check if they are in order. If not, all the skulls will turn off.
 * */

public class SkullController : MonoBehaviour {
    //Array of 7 skull references
    public GameObject[] skulls = new GameObject[7];
    //The current order the player has
    private ArrayList currentOrder;
    //Keeps count
    private int counter;
    //If the puzzle was completed or not
    public bool completed;
   
    
    // Use this for initialization
    void Start () {
        counter = 0;
        completed = false;
        currentOrder = new ArrayList();
        //Disable the sprite renderers for each skull
        for(int i = 0; i <= 6; i++)
        {
            skulls[i].GetComponent<SpriteRenderer>().enabled = false;
            if(i != 6)
                skulls[i].GetComponent<RobbieActivateSkull>().skullActivated = false;
            else
                skulls[i].GetComponent<RobbieActivateSkull7>().skullActivated = false;
        }

	}
	
	// Update is called once per frame
	void Update () {
        if (completed == false && (counter == 7) && Input.GetKeyUp("e"))
        {
            bool result = checkIfOrderCorrect();
            if (result) //correct order
            {
                //do stuff, light up altar
                completed = true;
                GameObject.Find("Altars").GetComponent<AltarController>().activateAltar(2);
            }
            else //reset the array
            {

                resetArray();
            }
        }
	}

    private void resetArray()
    {
        for(int i = 0; i <=6; i++)
        {
            //disable renderer of all skulls
            skulls[i].GetComponent<SpriteRenderer>().enabled = false;
            if(i != 6)
                skulls[i].GetComponent<RobbieActivateSkull>().skullActivated = false;
            else
                skulls[i].GetComponent<RobbieActivateSkull7>().skullActivated = false;
        }
        //Remove skulls from current order
        currentOrder.Clear();
        counter = 0;
    }

    private bool checkIfOrderCorrect()
    {
        for (int i = 0; i <= 6; i++)
        {
            if ((int)currentOrder[i] != (i + 1) )
            {
                return false;
            }
        }
        return true;
    }

    public void addArrayElement(int skullNumber)
    {
        currentOrder.Add(skullNumber);
        counter++;
    }
}
