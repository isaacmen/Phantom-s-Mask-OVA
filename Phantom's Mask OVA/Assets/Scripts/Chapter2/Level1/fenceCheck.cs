using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fenceCheck : MonoBehaviour {

    public GameObject ladder;

    //Checks who is touching it
    private bool yvetteTouching = false;
    private bool carolineTouching = false;
    private bool robbieTouching = false;

	
	// Update is called once per frame
	void Update () {
		if(yvetteTouching && Input.GetKeyDown("e"))
        {
            if(GameObject.Find("controlPlayerActive").GetComponent<controlPlayerActive>().isActiveName() == "Yvette")
            {
                ladder.GetComponent<fenceLadderCheck>().setFenceIsBusted(true);
        
                Destroy(gameObject);
            }
        }

        else if (robbieTouching && Input.GetKeyDown("e"))
        {
            if (GameObject.Find("controlPlayerActive").GetComponent<controlPlayerActive>().isActiveName() == "Robbie")
            {
                ladder.GetComponent<fenceLadderCheck>().setFenceIsBusted(false);
                Destroy(gameObject);
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D player)
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
