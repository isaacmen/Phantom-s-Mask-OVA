﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakBathroomMirror : MonoBehaviour {
    private bool isBreakable;
    private bool yvetteTouching;
    private bool christopherTouching;
    private bool carolineTouching;
    private bool veronicaTouching;
    private bool robbieTouching;
    public GameObject lever;


	// Use this for initialization
	void Start () {
        isBreakable = false;
        yvetteTouching = false;
        lever.GetComponent<Renderer>().enabled= false;
        lever.GetComponent<BoxCollider2D>().enabled = false;
    }
	
	// Update is called once per frame
	void Update () {
        string currentlyActive = GameObject.Find("controlPlayerActive").GetComponent<controlPlayerActive5people>().isActiveName();
        if (!isBreakable && Input.GetKey("e"))
        {
            if (yvetteTouching && (currentlyActive.Equals("Yvette")))
                GameObject.Find("LevelText").GetComponent<Lvl5Text>().MirrorInteract("Yvette (No Painting)");
            interactions(currentlyActive);
        }
        if (isBreakable)
            checkYvetteTouching(currentlyActive);
    }

    void interactions(string currentlyActive)
    {
        if (Input.GetKey("e"))
        {
            if (christopherTouching && (currentlyActive.Equals("Brian")))
                GameObject.Find("LevelText").GetComponent<Lvl5Text>().MirrorInteract("Christopher");
            else if (carolineTouching && (currentlyActive.Equals("Caroline")))
                GameObject.Find("LevelText").GetComponent<Lvl5Text>().MirrorInteract("Caroline");
            else if (veronicaTouching && (currentlyActive.Equals("Veronica")))
                GameObject.Find("LevelText").GetComponent<Lvl5Text>().MirrorInteract("Veronica");
            else if (robbieTouching && (currentlyActive.Equals("Robbie")))
                GameObject.Find("LevelText").GetComponent<Lvl5Text>().MirrorInteract("Robbie");
        }
    }

    void checkYvetteTouching(string activeName)
    {
        interactions(activeName);
        if (yvetteTouching && Input.GetKey("e"))
        {
            if (activeName.Equals("Yvette"))
            {
                // Activate the renderer for the lever
                lever.GetComponent<Renderer>().enabled = true;
                lever.GetComponent<BoxCollider2D>().enabled = true;
                //Show the text
                GameObject.Find("LevelText").GetComponent<Lvl5Text>().MirrorInteract("Yvette");
                Destroy(gameObject);
            }
        }
    }

    public void paintingSeen()
    {
        isBreakable = true;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Yvette")
            yvetteTouching = true;
        if (collision.name == "Robbie")
            robbieTouching = true;
        if (collision.name == "Caroline")
            carolineTouching = true;
        if (collision.name == "Veronica")
            veronicaTouching = true;
        if (collision.name == "Brian")
            christopherTouching = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.name == "Yvette")
            yvetteTouching = false;
        if (collision.name == "Robbie")
            robbieTouching = false;
        if (collision.name == "Caroline")
            carolineTouching = false;
        if (collision.name == "Veronica")
            veronicaTouching = false;
        if (collision.name == "Brian")
            christopherTouching = false;
    }
}
