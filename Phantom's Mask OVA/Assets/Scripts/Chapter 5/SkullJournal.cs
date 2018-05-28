using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkullJournal : MonoBehaviour {
    private ArrayList touching;
    // Use this for initialization
    void Start () {
        touching = new ArrayList();
    }
	
	// Update is called once per frame
	void Update () {
        string currentlyActive = GameObject.Find("controlPlayerActive").GetComponent<controlPlayerActive5people>().isActiveName();
        if (Input.GetKey("e") && (touching.IndexOf(currentlyActive) > -1))
        {
            GameObject.Find("txtreader").GetComponent<ReadTextLvl5>().active = true;
            GameObject.Find("txtreader").GetComponent<ReadTextLvl5>().pathFolder = "Assets/Texts/Chapter 5/Level Text/";
            GameObject.Find("txtreader").GetComponent<ReadTextLvl5>().filename = "Skull Journal.txt";
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
