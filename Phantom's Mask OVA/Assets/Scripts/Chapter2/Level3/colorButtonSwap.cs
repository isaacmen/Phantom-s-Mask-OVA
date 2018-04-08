using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorButtonSwap : MonoBehaviour {
    public GameObject o0;
    public GameObject o1;
    public GameObject o2;
    public GameObject o3;
    public GameObject o4;
    public GameObject wheel;
	
	// Update is called once per frame
	void Update () {
        if (wheel.GetComponent<FerrisWheelMovementNEW>().finished == false)
        {
            if (wheel.GetComponent<FerrisWheelMovementNEW>().playerOrder[0] != 0)
                o0.GetComponent<Renderer>().enabled = false;
            if (wheel.GetComponent<FerrisWheelMovementNEW>().playerOrder[0] == 0)
                o0.GetComponent<Renderer>().enabled = true;

            if (wheel.GetComponent<FerrisWheelMovementNEW>().playerOrder[1] != 0)
                o1.GetComponent<Renderer>().enabled = false;
            if (wheel.GetComponent<FerrisWheelMovementNEW>().playerOrder[1] == 0)
                o1.GetComponent<Renderer>().enabled = true;

            if (wheel.GetComponent<FerrisWheelMovementNEW>().playerOrder[2] != 0)
                o2.GetComponent<Renderer>().enabled = false;
            if (wheel.GetComponent<FerrisWheelMovementNEW>().playerOrder[2] == 0)
                o2.GetComponent<Renderer>().enabled = true;

            if (wheel.GetComponent<FerrisWheelMovementNEW>().playerOrder[3] != 0)
                o3.GetComponent<Renderer>().enabled = false;
            if (wheel.GetComponent<FerrisWheelMovementNEW>().playerOrder[3] == 0)
                o3.GetComponent<Renderer>().enabled = true;
  
            if (wheel.GetComponent<FerrisWheelMovementNEW>().playerOrder[4] != 0)
                o4.GetComponent<Renderer>().enabled = false;
            if (wheel.GetComponent<FerrisWheelMovementNEW>().playerOrder[4] == 0)
                o4.GetComponent<Renderer>().enabled = true;

            if (wheel.GetComponent<FerrisWheelMovementNEW>().counter == 5)
            {
                checkArrayMatch(wheel.GetComponent<FerrisWheelMovementNEW>().correctOrder, wheel.GetComponent<FerrisWheelMovementNEW>().playerOrder);   
            }
        }
    }

    public bool checkArrayMatch(int[] a, int[] b)
    {
        for (int i = 0; i <= 4; i++)
        {
            if (a[i] != b[i])
            {
                return false;
            }
        }
        wheel.GetComponent<FerrisWheelMovementNEW>().setFinishedTrue();
        return true;
    }
}
