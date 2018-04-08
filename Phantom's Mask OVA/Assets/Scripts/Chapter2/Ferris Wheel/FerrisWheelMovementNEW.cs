using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FerrisWheelMovementNEW : MonoBehaviour
{

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
    }

    // Update is called once per frame
    void Update ()
    {
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
}
