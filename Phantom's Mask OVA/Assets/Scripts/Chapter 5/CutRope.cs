using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutRope : MonoBehaviour {
    //Characters currently touching the Rope
    private ArrayList touching;

    // Use this for initialization
    void Start () {
        touching = new ArrayList();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey("e"))
        {
            string currentlyActive = GameObject.Find("controlPlayerActive").GetComponent<controlPlayerActive5people>().isActiveName();
            if (currentlyActive.Equals("Veronica") && touching.IndexOf(currentlyActive) > -1)
            {
                //Cut the Rope!
                Destroy(gameObject);
            }

            else if (touching.IndexOf(currentlyActive) > -1)
            {
                if (currentlyActive.Equals("Brian"))
                    GameObject.Find("LevelText").GetComponent<Lvl5Text>().RopeInteract("Christopher");
                else
                    GameObject.Find("LevelText").GetComponent<Lvl5Text>().RopeInteract(currentlyActive);
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
