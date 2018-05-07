using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixFridge : MonoBehaviour {
   
    public bool foundToolbox;
    public bool robbieTouching;
	// Use this for initialization
	void Start () {
        foundToolbox = false; 
	}
	
	// Update is called once per frame
	void Update () {
		if(foundToolbox == true)
        {
            FixTheFridge();
        }
	}

    public void FixTheFridge()
    {
        if(robbieTouching && Input.GetKeyDown("e"))
        {
            if(GameObject.Find("PlayerController").GetComponent<controlPlayerActive>().isActiveName() == "Robbie")
            {
                //Yay fixed the fridge get diary level over after text stuff
            }
        }
        
    }

    public void SetFoundToolbox()
    {
        foundToolbox = true;
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Robbie")
            robbieTouching = true;
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.name == "Robbie")
            robbieTouching = false;
    }
}
