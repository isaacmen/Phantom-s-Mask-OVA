using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarolineDetectLadder : MonoBehaviour {

    private bool carolineTouching;
    private bool bookshelfIsBroken;
    //people touching the rug that aren't Caroline
    private ArrayList touching;

    // Use this for initialization
    void Start () {
        touching = new ArrayList();
        carolineTouching = false;
        bookshelfIsBroken = false;
        //Disable the ladder
        GameObject.Find("BathroomFloorLadder").GetComponent<BoxCollider2D>().enabled = false;
        GameObject.Find("BathroomFloorLadder").GetComponent<SpriteRenderer>().enabled = false;
    }
	
	// Update is called once per frame
	void Update () {
        if (bookshelfIsBroken)
            checkCarolineDetected();
	}

    public void checkCarolineDetected()
    {
        if(Input.GetKey("e"))
        {
            string currentlyActive = GameObject.Find("controlPlayerActive").GetComponent<controlPlayerActive5people>().isActiveName();
            if (carolineTouching == true && currentlyActive == "Caroline")
            {
                //Door not covered anymore
                gameObject.GetComponent<SpriteRenderer>().enabled = false;
                //enable ladder
                GameObject.Find("BathroomFloorLadder").GetComponent<BoxCollider2D>().enabled = true;
                GameObject.Find("BathroomFloorLadder").GetComponent<SpriteRenderer>().enabled = true;
                GameObject.Find("LevelText").GetComponent<Lvl5Text>().RugInteract("Caroline");
                Destroy(GameObject.Find("TemporaryFloor"));
            }
            else if(touching.IndexOf(currentlyActive) > -1)
            {
                if (currentlyActive.Equals("Brian"))
                    GameObject.Find("LevelText").GetComponent<Lvl5Text>().RugInteract("Christopher");
                else if (currentlyActive.Equals("Veronica"))
                    Debug.Log("No Veronica Rug Interaction");//No script for her :c 
                else
                    GameObject.Find("LevelText").GetComponent<Lvl5Text>().RugInteract(currentlyActive);
            }
        }
    }

    public void BookshelfBroke()
    {
        bookshelfIsBroken = true;
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Caroline")
            carolineTouching = true;
        else
            touching.Add(collision.name);
    }


    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.name == "Caroline")
            carolineTouching = false;
        else
            touching.Remove(collision.name);
    }
}
