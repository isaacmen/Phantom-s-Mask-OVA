using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FerrisWheelMovement : MonoBehaviour {

    // The speed it should move in, 60 recommended
    public int speed;

    //The Ferris Wheel's rigid body
    private Rigidbody2D fw; 

    /// Whether the ferris wheel should stay still. Will Stay still when none of the buttons are pressed / When Robbie isn't activating them
    private bool stayStill;

    // The buttons, these trigger when one of them is active
    private bool spinRight;
    private bool spinLeft;

	// Use this for initialization
	void Start () {
        //Shoud be set to true
        fw = GetComponent<Rigidbody2D>();
        changeStayStill(false);
        spinRight = false;
        spinLeft = false;
	}
	
	// Update is called once per frame
	void Update () {
        if(stayStill == false)
        {
            if (spinRight)
                spinRightMove();
            else if (spinLeft)
                spinLeftMove();
        }

	}

    /// MOVEMENT FUNCTIONS ///
    public void spinRightMove()
    {
        fw.MoveRotation(fw.rotation - speed * Time.deltaTime);
    }

    public void spinLeftMove()
    {
        fw.MoveRotation(fw.rotation + speed * Time.deltaTime);
    }

    /// ACTIVATE BUTTON FUNCTIONS ///
    public void activateRightSpin()
    {
        //Disactivate all other buttons that aren't right spin
        spinLeft = false;

        //Activate right spin
        spinRight = true;
    }

    public void activateLeftSpin()
    {
        //Disactivate all other buttons that aren't left spin
        spinRight = false;

        //Activate right spin
        spinLeft = true;
    }

    // Change whether the ferris wheel should stay still or not
    public void changeStayStill(bool move)
    {
        stayStill = move;
        if(stayStill == true)
        {
            GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeRotation | RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY;
        }
   
        else
        {
            //Remove all constraints
            GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None;
            //Freeze x and y axis though
            GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY;
        }
    }

}
