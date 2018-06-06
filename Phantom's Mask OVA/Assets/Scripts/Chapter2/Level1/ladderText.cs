using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ladderText : MonoBehaviour {
	private bool yvetteTouching = false;
    private bool carolineTouching = false;
    private bool robbieTouching = false;

	private const string LadderCaroline = "Ladder_Caroline.txt";
	private const string LadderRobbieBroken = "Ladder_Robbie (without fence piece).txt";
	private const string LadderRobbieFixed = "Ladder_Robbie (with fence piece).txt";
	private const string LadderYvette = "Ladder_Yvette.txt";
	
	public Sprite mySprite;
	
	private GameObject reader;

	// Use this for initialization
	void Start () {
		reader = GameObject.FindGameObjectWithTag("textbox");
	}
	
	// Update is called once per frame
	void Update () {
		if (carolineTouching && Input.GetKeyDown("e")){
			if(GameObject.Find("controlPlayerActive").GetComponent<controlPlayerActive>().isActiveName() == "Caroline"){
				reader.GetComponent<ReadText>().active = true;
				reader.GetComponent<ReadText>().filename = LadderCaroline;
			}
		}
		
		else if (robbieTouching && Input.GetKeyDown("e")){
			if(GameObject.Find("controlPlayerActive").GetComponent<controlPlayerActive>().isActiveName() == "Robbie"){
				reader.GetComponent<ReadText>().active = true;
				if(gameObject.GetComponent<fenceLadderCheck>().checkFenceIsBusted() == true){
					reader.GetComponent<ReadText>().filename = LadderRobbieBroken;
				}
				else{
					this.GetComponent<SpriteRenderer>().sprite = mySprite;
					reader.GetComponent<ReadText>().filename = LadderRobbieFixed;
				}
			}
		}
		
		else if (yvetteTouching && Input.GetKeyDown("e")){
			if(GameObject.Find("controlPlayerActive").GetComponent<controlPlayerActive>().isActiveName() == "Yvette"){
				reader.GetComponent<ReadText>().active = true;
				reader.GetComponent<ReadText>().filename = LadderYvette;
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
