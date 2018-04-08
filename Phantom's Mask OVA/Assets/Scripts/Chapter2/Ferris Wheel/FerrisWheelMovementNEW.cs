using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FerrisWheelMovementNEW : MonoBehaviour
{

    //THE CORRECT ORDER THAT WILL MAKE IT WORK
    private int[] correctOrder = new int[] { 1, 2, 3, 4, 5 };
    private int[] playerOrder = new int[] { 0, 0, 0, 0, 0 };
    //keeps track of the current button clicked
    int counter;


    void Start() {
        counter = 0;
    }

    // Update is called once per frame
    void Update ()
    {
	}


    public void setButton(int i)
    {
        playerOrder[counter] = i;
        counter += 1;
        Debug.Log(counter);
        checkCounter();
    }

    public void checkCounter()
    {
        if (counter > 4)
        {
            counter = 0;
            Debug.Log("------Reset");
            //printArr();
        }
    }
    public bool checkArrayMatch()
    {
        for(int f = 0; f <= 4; f++)
        {
            if (correctOrder[f] != playerOrder[f])
                 return false;
        }
        return true;
    }


    public void printArr()
    {
        Debug.Log("    --------------");
        for (int f = 0; f <= 4; f++)
        {
           Debug.Log(correctOrder[f] + " ^  " + playerOrder[f]);
        }
        Debug.Log("    ---------------");
    }
}
