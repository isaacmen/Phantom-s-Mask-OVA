using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinRight : MonoBehaviour {
    private static bool spin;
    public GameObject ferrisWheel;
    private static bool robbieTouching;

	// Use this for initialization
	void Start () {
        spin = false;
        robbieTouching = false;
	}
	
	// Update is called once per frame
	void Update () {
        //ferrisWheel.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeRotation | RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY;
        if (spin == false)
        {
            ferrisWheel.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeRotation | RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY;
            checkRobbieActivated();
        }
        else
        {
            rightSpin();
        }
    }

    private void rightSpin()
    {
        Debug.Log("Spinning....");
        Rigidbody2D r = ferrisWheel.GetComponent<Rigidbody2D>();
        r.MoveRotation(r.rotation + 10 * Time.deltaTime);
    }


    private void checkRobbieActivated()
    {
        if(robbieTouching && Input.GetKeyDown("e"))
        {
            //Robbie pressed e and he is active
            if(GameObject.Find("controlPlayerActive").GetComponent<controlPlayerActive>().isActiveName() == "Robbie")
            {
                spin = true;
                
                //Remove all constraints
                ferrisWheel.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None;
                //Freeze x and y axis though
                ferrisWheel.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY;
               
            }
        }
    }



    private void OnTriggerEnter2D(Collider2D player)
    {
        if(player.gameObject.name == "Robbie")
        {
            robbieTouching = true;
        }
    }

    private void OnTriggerExit2D(Collider2D player)
    {
        if (player.gameObject.name == "Robbie")
        {
            robbieTouching = false;
        }
    }


}
