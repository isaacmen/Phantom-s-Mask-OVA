using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pushableCouch : MonoBehaviour {

    //Has to match Brian's speed
    public float speed;
    private bool brianTouching;
    private bool objectHasBeenPushed;
    private ArrayList touching;

    void Start()
    {
        touching = new ArrayList();
        brianTouching = false;
        objectHasBeenPushed = false;
    }

    void Update()
    {
        string currentlyActive = GameObject.Find("controlPlayerActive").GetComponent<controlPlayerActive5people>().isActiveName();
        if (!objectHasBeenPushed)
        {
            //People can communicate with it that aren't Brian
            if(Input.GetKey("e") && touching.IndexOf(currentlyActive) > -1)
            {
                GameObject.Find("LevelText").GetComponent<Lvl5Text>().CouchInteract(currentlyActive);
            }
        }
        if (brianTouching == true && Input.GetKey("e"))
           if (currentlyActive == "Brian")
              HandleMovement();
        
    }

    void HandleMovement()
    {
        objectHasBeenPushed = true;
        if (Input.GetKey("a"))
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("d"))
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);
        }
    }

    void OnCollisionEnter2D(Collision2D player)
    {
        if (player.gameObject.name == "Brian")
            brianTouching = true;
        else
        {
            Debug.Log(player.gameObject.name);
            touching.Add(player.gameObject.name);
        }
    }

    void OnCollisionExit2D(Collision2D player)
    {
        if (player.gameObject.name == "Brian")
            brianTouching = false;
        else
            touching.Remove(player.gameObject.name);
    }


}
