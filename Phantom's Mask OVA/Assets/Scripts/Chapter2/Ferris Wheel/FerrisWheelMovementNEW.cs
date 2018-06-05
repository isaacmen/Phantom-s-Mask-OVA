using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FerrisWheelMovementNEW : MonoBehaviour
{
    // The speed it should move in, 60 recommended
    public int speed;

    //The top cart
    public GameObject topCart;

    //The Ferris Wheel's rigid body
    private Rigidbody2D fw;

    /// Whether the ferris wheel should stay still. Will Stay still when none of the buttons are pressed / When Robbie isn't activating them
    private bool stayStill;

    //THE CORRECT ORDER THAT WILL MAKE IT WORK
    public int[] correctOrder = new int[] { 1, 2, 3, 4, 5 };
    public int[] playerOrder = new int[] { 0, 0, 0, 0, 0 };
    //keeps track of the current button clicked
    public int counter = 0;
    public bool finished = false;


    void Start() {
        counter = 0;
        finished = false;
        playerOrder = new int[] { 0, 0, 0, 0, 0 };
        fw = GetComponent<Rigidbody2D>();
        changeStayStill(true);
    }

    // Update is called once per frame
    void Update ()
    {
        if (stayStill == false)
        {
            spinLeftMove();
            checkCartAtBottom();
        }
    }


    public void setButton(int i)
    {
        if(finished == false)
        {
            if (counter >= 5)
            {
                playerOrder[0] = 0;
                playerOrder[1] = 0;
                playerOrder[2] = 0;
                playerOrder[3] = 0;
                playerOrder[4] = 0;
                counter = 0;
            }
            playerOrder[counter] = i;
            ++counter;
        }
    }
    
    public void setFinishedTrue()
    {
        finished = true;
    }

    public void spinLeftMove()
    {
        fw.MoveRotation(fw.rotation + speed * Time.deltaTime);
    }

    // Change whether the ferris wheel should stay still or not
    public void changeStayStill(bool move)
    {
        stayStill = move;
        if (stayStill == true)
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

    public void checkCartAtBottom()
    {
        if (topCart.transform.position.x > -5.56 && topCart.transform.position.y < -3.56)
        {
            changeStayStill(true);
        }
    }
}
