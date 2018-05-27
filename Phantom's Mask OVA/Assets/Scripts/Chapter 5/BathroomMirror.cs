using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BathroomMirror : MonoBehaviour {
    private bool read;
    private ArrayList touching;
	// Use this for initialization
	void Start () {
        read = false;
        touching = new ArrayList();
    }
	
	// Update is called once per frame
	void Update () {
		if(!read)
        {
            readLine();
        }
	}


    private void readLine()
    {
        string currentlyActive = GameObject.Find("controlPlayerActive").GetComponent<controlPlayerActive5people>().isActiveName();
        if (touching.IndexOf(currentlyActive) > -1)
        {
            if (Input.GetKey("e"))
            {
                //Interact with it
                GameObject.Find("txtreader").GetComponent<ReadTextLvl5>().active = true;
                GameObject.Find("txtreader").GetComponent<ReadTextLvl5>().pathFolder = "Assets/Texts/Chapter 5/Level Text/";
                GameObject.Find("txtreader").GetComponent<ReadTextLvl5>().filename = "Bathroom Painting.txt";
                read = true;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        touching.Add(collision.name);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        touching.Remove(collision.name);
    }

}

