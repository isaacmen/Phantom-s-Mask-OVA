using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlPlayerActive : MonoBehaviour {
    public GameObject p1;
    public GameObject p2;
    public GameObject p3;

    private int counter; //keeps track of counter, which character should move

	// Use this for initialization
	void Start () {
        //Enable Character 1 first, disable chars 2 and 3
        //Getting the script that controls the player and disabling it for 2 and 3
        p1.GetComponent<playerControler>().enabled = true;
        p2.GetComponent<playerControler>().enabled = false;
        p3.GetComponent<playerControler>().enabled = false;
        counter = 2;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            if (counter == 1) //Character 1 is in control
            {
                p1.GetComponent<playerControler>().enabled = true;
                p2.GetComponent<playerControler>().enabled = false;
                p3.GetComponent<playerControler>().enabled = false;
                counter++;
            }
            else if (counter == 2) //Character 2 is in control
            {
                p1.GetComponent<playerControler>().enabled = false;
                p2.GetComponent<playerControler>().enabled = true;
                p3.GetComponent<playerControler>().enabled = false;
                counter++;
            }
            else if (counter == 3) //Character 3 is in control
            {
                p1.GetComponent<playerControler>().enabled = false;
                p2.GetComponent<playerControler>().enabled = false;
                p3.GetComponent<playerControler>().enabled = true;
                counter = 1; //reset
            }
        }
    }
}
