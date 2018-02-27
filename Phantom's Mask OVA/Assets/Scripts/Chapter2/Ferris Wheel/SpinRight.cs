using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinRight : MonoBehaviour {
    public GameObject ferrisWheel;
    private static bool robbieTouching;


    // Use this for initialization
    void Start () {
        robbieTouching = false;
 
    }
	
	// Update is called once per frame
	void Update () {

        checkRobbieActivated();
    }


    private void checkRobbieActivated()
    {
        if(robbieTouching && Input.GetKeyDown("e"))
        {
            //Robbie pressed e and he is active
            if(GameObject.Find("controlPlayerActive").GetComponent<controlPlayerActive>().isActiveName() == "Robbie")
            {
                ferrisWheel.GetComponent<FerrisWheelMovement>().activateRightSpin();
            }
        }
    }



    private void OnTriggerEnter2D(Collider2D player)
    {
        if(player.gameObject.name == "Robbie")
        {
            robbieTouching = true;
        }
    }

    private void OnTriggerExit2D(Collider2D player)
    {
        if (player.gameObject.name == "Robbie")
        {
            robbieTouching = false;
        }
    }


}
