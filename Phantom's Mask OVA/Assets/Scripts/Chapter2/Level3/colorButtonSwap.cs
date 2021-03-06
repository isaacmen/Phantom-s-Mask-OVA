﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorButtonSwap : MonoBehaviour {
    //Go back button
    public GameObject goBack;

    //The buttons
    public GameObject o0;
    public GameObject o1;
    public GameObject o2;
    public GameObject o3;
    public GameObject o4;
    public GameObject wheel;

    //Ferris wheel off image
    public GameObject ferrisWheelOn;

    //Machine works sound
    public GameObject sound;

    public UnityEngine.UI.Text Displaytext;
    public UnityEngine.UI.Image Textbox;

    // Update is called once per frame
    void Update () {
        if (wheel.GetComponent<FerrisWheelMovementNEW>().finished == false && !GameObject.Find("txtreader").GetComponent<ReadText>().active)
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
                //Wrong text
                GameObject.Find("txtreader").GetComponent<ReadText>().active = true;
                GameObject.Find("txtreader").GetComponent<ReadText>().filename = "Incorrect Console Password.txt";
                //
                wheel.GetComponent<FerrisWheelMovementNEW>().playerOrder[0] = 0;
                wheel.GetComponent<FerrisWheelMovementNEW>().playerOrder[1] = 0;
                wheel.GetComponent<FerrisWheelMovementNEW>().playerOrder[2] = 0;
                wheel.GetComponent<FerrisWheelMovementNEW>().playerOrder[3] = 0;
                wheel.GetComponent<FerrisWheelMovementNEW>().playerOrder[4] = 0;
                wheel.GetComponent<FerrisWheelMovementNEW>().counter = 0;
                

                return false;
            }
        }
        wheel.GetComponent<FerrisWheelMovementNEW>().setFinishedTrue();
        wheel.GetComponent<FerrisWheelMovementNEW>().changeStayStill(false);
        //READ THE TEXT //
        Textbox.gameObject.SetActive(true);
        Destroy(goBack);
        Displaytext.text = "Robbie: \"Hey, I think I got it! Guys! Over here!\"";
        //End Scene
        StartCoroutine(wait());
        return true;
    }

    IEnumerator wait()
    {
        //Turn ferris wheel on sprite
        ferrisWheelOn.gameObject.SetActive(true);
        sound.GetComponent<AudioSource>().enabled = true;
        yield return new WaitForSeconds(5);
        //End Scene
        GameObject.Find("SceneChange").GetComponent<changeScene>().active = true;
    }
}

