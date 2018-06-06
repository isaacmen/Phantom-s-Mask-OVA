using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fenceCheck : MonoBehaviour {

    public GameObject ladder;

    //Checks who is touching it
    private bool yvetteTouching = false;
    private bool carolineTouching = false;
    private bool robbieTouching = false;
	
	private const string FenceCaroline = "Fence_Caroline.txt";
	private const string FenceRobbie = "Fence_Robbie (when Yvette breaks it).txt";
	private const string FenceYvette = "Fence_Yvette (When Robbie takes it apart).txt";
	
	private bool carolineTouched = false;

	
	//Textbox to read to
    private GameObject reader;

    void Start()
    {
        reader = GameObject.FindGameObjectWithTag("textbox");
    }
	
	// Update is called once per frame
	void Update () {
		if(yvetteTouching && Input.GetKeyDown("e") && carolineTouched)
        {
            if(GameObject.Find("controlPlayerActive").GetComponent<controlPlayerActive>().isActiveName() == "Yvette")
            {
                ladder.GetComponent<fenceLadderCheck>().setFenceIsBusted(true);
                Destroy(gameObject);
				reader.GetComponent<ReadText>().active = true;
				reader.GetComponent<ReadText>().filename = FenceRobbie;
            }
        }
		
		else if (carolineTouching && Input.GetKeyDown("e")){
			if(GameObject.Find("controlPlayerActive").GetComponent<controlPlayerActive>().isActiveName() == "Caroline"){
					reader.GetComponent<ReadText>().active = true;
					reader.GetComponent<ReadText>().filename = FenceCaroline;
					carolineTouched = true;
			}
		}

        else if (robbieTouching && Input.GetKeyDown("e") && carolineTouched)
        {
            if (GameObject.Find("controlPlayerActive").GetComponent<controlPlayerActive>().isActiveName() == "Robbie")
            {
                ladder.GetComponent<fenceLadderCheck>().setFenceIsBusted(false);
                Destroy(gameObject);
				reader.GetComponent<ReadText>().active = true;
				reader.GetComponent<ReadText>().filename = FenceYvette;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D player)
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

    private void OnTriggerExit2D(Collider2D player)
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
