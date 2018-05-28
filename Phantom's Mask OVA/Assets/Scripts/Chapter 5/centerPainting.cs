using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class centerPainting : MonoBehaviour {
    private bool hasBeenSeen;
    private ArrayList touching;
    public GameObject mirror;

	// Use this for initialization
	void Start () {
        hasBeenSeen = false;
        touching = new ArrayList();
	}
	
	// Update is called once per frame
	void Update () {
        if (!hasBeenSeen)
            checkifSeen();
	}

    private void readLine()
    {

       GameObject.Find("txtreader").GetComponent<ReadTextLvl5>().active = true;
       GameObject.Find("txtreader").GetComponent<ReadTextLvl5>().pathFolder = "Assets/Texts/Chapter 5/Level Text/";
       GameObject.Find("txtreader").GetComponent<ReadTextLvl5>().filename = "Bathroom Painting.txt";
    }

    private void checkifSeen()
    {
        string currentlyActive = GameObject.Find("controlPlayerActive").GetComponent<controlPlayerActive5people>().isActiveName();
        if(touching.IndexOf(currentlyActive) > -1)
        {
            if (Input.GetKeyUp("e"))
            {
                readLine();
                //Painting has been seen
                hasBeenSeen = true;
                mirror.GetComponent<BreakBathroomMirror>().paintingSeen();
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
