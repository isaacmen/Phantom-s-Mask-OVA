using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakableHalfBookcase : MonoBehaviour {

    //Whether Yvette is touching this object or not
    private bool yvetteTouching;

    // Use this for initialization
    void Start()
    {
        yvetteTouching = false;
        //Disable the renderer
        gameObject.GetComponent<Renderer>().enabled = false;
        //You can't jump on the broken bookcase right now
        GameObject.Find("BrokenBookcaseGroundCollider").GetComponent<BoxCollider2D>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        checkObjectBroke();
    }

    public void checkObjectBroke()
    {
        if (yvetteTouching == true && Input.GetKey("e"))
        {
            if (GameObject.Find("controlPlayerActive").GetComponent<controlPlayerActive5people>().isActiveName() == "Yvette")
            { 
                gameObject.GetComponent<Renderer>().enabled = true;
                GameObject.Find("BrokenBookcaseGroundCollider").GetComponent<BoxCollider2D>().enabled = true;
                GameObject.Find("Bathroom Door Covered").GetComponent<CarolineDetectLadder>().BookshelfBroke();
            }

        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Yvette")
            yvetteTouching = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.name == "Yvette")
            yvetteTouching = false;
    }

}
