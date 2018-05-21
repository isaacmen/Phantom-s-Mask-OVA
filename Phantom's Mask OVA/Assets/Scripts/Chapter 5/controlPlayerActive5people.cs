using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlPlayerActive5people : MonoBehaviour
{
    public GameObject p1;
    public GameObject p2;
    public GameObject p3;
    public GameObject p4;
    public GameObject p5;

    //Hide it, shouldn't show up in inspector
    [HideInInspector]
    public GameObject isActive; //Keeps track of the gameobject that is Active so other scripts can access this

    private int counter; //keeps track of counter, which character should move. Can only be used in this script (static)

    // Use this for initialization
    void Start()
    {
        //Enable Character 1 first, disable chars 2 and 3
        //Getting the script that controls the player and disabling it for 2 and 3
        p1.GetComponent<playerControler>().enabled = true;
        p2.GetComponent<playerControler>().enabled = false;
        p3.GetComponent<playerControler>().enabled = false;
        p4.GetComponent<playerControler>().enabled = false;
        p5.GetComponent<playerControler>().enabled = false;
        p1.GetComponent<SpriteRenderer>().sortingLayerName = "MainPlayer";
        p2.GetComponent<SpriteRenderer>().sortingLayerName = "BackgroundPlayer";
        p3.GetComponent<SpriteRenderer>().sortingLayerName = "BackgroundPlayer";
        p4.GetComponent<SpriteRenderer>().sortingLayerName = "BackgroundPlayer";
        p5.GetComponent<SpriteRenderer>().sortingLayerName = "BackgroundPlayer";
        counter = 1;
        isActive = p1;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            if (counter == 1) //Character 1 is in control
            {
                p1.GetComponent<playerControler>().enabled = true;
                p2.GetComponent<playerControler>().enabled = false;
                p3.GetComponent<playerControler>().enabled = false;
                p4.GetComponent<playerControler>().enabled = false;
                p5.GetComponent<playerControler>().enabled = false;
                p1.GetComponent<SpriteRenderer>().sortingLayerName = "MainPlayer";
                p2.GetComponent<SpriteRenderer>().sortingLayerName = "BackgroundPlayer";
                p3.GetComponent<SpriteRenderer>().sortingLayerName = "BackgroundPlayer";
                p4.GetComponent<SpriteRenderer>().sortingLayerName = "BackgroundPlayer";
                p5.GetComponent<SpriteRenderer>().sortingLayerName = "BackgroundPlayer";
                isActive = p1;
                counter = 2;
            }
            else if (counter == 2) //Character 2 is in control
            {
                p1.GetComponent<playerControler>().enabled = false;
                p2.GetComponent<playerControler>().enabled = true;
                p3.GetComponent<playerControler>().enabled = false;
                p4.GetComponent<playerControler>().enabled = false;
                p5.GetComponent<playerControler>().enabled = false;
                p1.GetComponent<SpriteRenderer>().sortingLayerName = "BackgroundPlayer";
                p2.GetComponent<SpriteRenderer>().sortingLayerName = "MainPlayer";
                p3.GetComponent<SpriteRenderer>().sortingLayerName = "BackgroundPlayer";
                p4.GetComponent<SpriteRenderer>().sortingLayerName = "BackgroundPlayer";
                p5.GetComponent<SpriteRenderer>().sortingLayerName = "BackgroundPlayer";
                isActive = p2;
                counter = 3;
            }
            else if (counter == 3) //Character 3 is in control
            {
                p1.GetComponent<playerControler>().enabled = false;
                p2.GetComponent<playerControler>().enabled = false;
                p3.GetComponent<playerControler>().enabled = true;
                p4.GetComponent<playerControler>().enabled = false;
                p5.GetComponent<playerControler>().enabled = false;
                p1.GetComponent<SpriteRenderer>().sortingLayerName = "BackgroundPlayer";
                p2.GetComponent<SpriteRenderer>().sortingLayerName = "BackgroundPlayer";
                p3.GetComponent<SpriteRenderer>().sortingLayerName = "MainPlayer";
                p4.GetComponent<SpriteRenderer>().sortingLayerName = "BackgroundPlayer";
                p5.GetComponent<SpriteRenderer>().sortingLayerName = "BackgroundPlayer";
                isActive = p3;
                counter = 4; 
            }
            else if (counter == 4) //Character 4 is in control
            {
                p1.GetComponent<playerControler>().enabled = false;
                p2.GetComponent<playerControler>().enabled = false;
                p3.GetComponent<playerControler>().enabled = false;
                p4.GetComponent<playerControler>().enabled = true;
                p5.GetComponent<playerControler>().enabled = false;
                p1.GetComponent<SpriteRenderer>().sortingLayerName = "BackgroundPlayer";
                p2.GetComponent<SpriteRenderer>().sortingLayerName = "BackgroundPlayer";
                p3.GetComponent<SpriteRenderer>().sortingLayerName = "BackgroundPlayer";
                p4.GetComponent<SpriteRenderer>().sortingLayerName = "MainPlayer";
                p5.GetComponent<SpriteRenderer>().sortingLayerName = "BackgroundPlayer";
                isActive = p4;
                counter = 5; 
            }
            else if (counter == 5) //Character 5 is in control
            {
                p1.GetComponent<playerControler>().enabled = false;
                p2.GetComponent<playerControler>().enabled = false;
                p3.GetComponent<playerControler>().enabled = false;
                p4.GetComponent<playerControler>().enabled = false;
                p5.GetComponent<playerControler>().enabled = true;
                p1.GetComponent<SpriteRenderer>().sortingLayerName = "BackgroundPlayer";
                p2.GetComponent<SpriteRenderer>().sortingLayerName = "BackgroundPlayer";
                p3.GetComponent<SpriteRenderer>().sortingLayerName = "BackgroundPlayer";
                p4.GetComponent<SpriteRenderer>().sortingLayerName = "BackgroundPlayer";
                p5.GetComponent<SpriteRenderer>().sortingLayerName = "MainPlayer";
                isActive = p5;
                counter = 1; //reset
            }
        }
    }

    //Returns the GameObject that is active
    public GameObject isActiveO()
    {
        return isActive;
    }

    //Returns the name of the GameObject that is active
    public string isActiveName()
    {
        return isActive.name;
    }
}
