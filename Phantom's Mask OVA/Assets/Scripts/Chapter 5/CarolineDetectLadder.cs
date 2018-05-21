using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarolineDetectLadder : MonoBehaviour {

    private bool carolineTouching;
    private bool bookshelfIsBroken;
	// Use this for initialization
	void Start () {
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
        if(carolineTouching == true && Input.GetKey("e"))
        {
            if (GameObject.Find("controlPlayerActive").GetComponent<controlPlayerActive5people>().isActiveName() == "Caroline")
            {
                //Door not covered anymore
                gameObject.GetComponent<SpriteRenderer>().enabled = false;
                //enable ladder
                GameObject.Find("BathroomFloorLadder").GetComponent<BoxCollider2D>().enabled = true;
                GameObject.Find("BathroomFloorLadder").GetComponent<SpriteRenderer>().enabled = true;
                Destroy(GameObject.Find("TemporaryFloor"));
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
    }


    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.name == "Caroline")
            carolineTouching = false;
    }
}
