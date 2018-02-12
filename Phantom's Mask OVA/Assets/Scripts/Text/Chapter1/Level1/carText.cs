using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Controls the Text script on the Car. Handles plyer interaction with the car
 * This script uses the following classes from Car:
 *          -CarMovement
 *          -CarCheckFix
 */ 
public class carText : MonoBehaviour {
    //The files the car will use
    //All private cosnts, these file names won't be changed nor used by other scripts
    private const string brokenCarAfterInspection_Caroline = "BrokenCar(afterInspection)-Caroline.txt";
    private const string brokenCarAfterInspection_Yvette = "BrokenCar(afterInspection)-Yvette.txt";
    private const string brokenCarBeforeInspection_Robbie = "BrokenCar(beforeInspection)-Robbie.txt";
    private const string brokenCarBeforeInspection_Yvette = "BrokenCar(beforeInspection)-Yvette.txt";
    private const string CarolineDetect_car = "CarolineDetect-Car.txt";
    private const string RobbieFixCar = "RobbieFixCar.txt";

    //Booleans that check whether the player is touching the car for the first time or not
    //These bools will be manipulated based off who is touching the car and the situation
    private static bool carolineTouch = false;
    private static bool robbieTouch = false;
    private static bool yvetteTouch = false;

    //Booleans that check if Caroline has said her lines to fix the car
    private static bool carolineFixed = false;

    //Booleans that determine if they are otuching the car
    private bool carolineTouching = false;
    private bool robbieTouching = false;
    private bool yvetteTouching = false;

    // Update is called once per frame
    void Update () {
        //If the car was fixed, disable this script
        checkCarFixed();

        //If caroline figured out what's wrong with the car but robbie hasn't
        if (gameObject.GetComponent<carCheckFix>().carolineActivated && carolineFixed)
            robbieCheckCar();

        //If Caroline hasn't figured out what is wrong with the car
        if (carolineFixed == false)
            carolineCheckCar();

    }

    //Handles text if caroline has checked the car already, but Robbie hasn't
    void robbieCheckCar()
    {
        //If Caroline already figured out what is wrong with the car and she said her lines
        //Yvette's Line if Yvette is the active player
        if (yvetteTouching && !yvetteTouch && GameObject.Find("controlPlayerActive").GetComponent<controlPlayerActive>().isActiveName() == "Yvette" && Input.GetKey("e"))
        {
            gameObject.GetComponent<ReadText>().active = true;
            gameObject.GetComponent<ReadText>().filename = brokenCarAfterInspection_Yvette;
            yvetteTouch = true;
        }

        //Caroline text if Caroline is the active player
        if (carolineTouching && !carolineTouch && GameObject.Find("controlPlayerActive").GetComponent<controlPlayerActive>().isActiveName() == "Caroline" && Input.GetKey("e"))
        {
            gameObject.GetComponent<ReadText>().active = true;
            gameObject.GetComponent<ReadText>().filename = brokenCarAfterInspection_Caroline;
            carolineTouch = true;
        }

        if (robbieTouching && GameObject.Find("controlPlayerActive").GetComponent<controlPlayerActive>().isActiveName() == "Robbie" && Input.GetKey("e"))
        {
            gameObject.GetComponent<ReadText>().active = true;
            gameObject.GetComponent<ReadText>().filename = RobbieFixCar;
        }
    }

    //Handles text if Caroline HASN'T checked the car yet, as well
    //As if Caroline checks the car
    void carolineCheckCar()
    {

        //Robbie's line
        //If Robbie is touching the car and he hasn't touched the car yet
        //if (gameObject.GetComponent<carCheckFix>().robbieTouching && !robbieTouch && GameObject.Find("controlPlayerActive").GetComponent<controlPlayerActive>().isActiveName() == "Robbie" && Input.GetKey("e"))
        if (robbieTouching && !robbieTouch && GameObject.Find("controlPlayerActive").GetComponent<controlPlayerActive>().isActiveName() == "Robbie" && Input.GetKey("e"))
        {
            gameObject.GetComponent<ReadText>().active = true;
            gameObject.GetComponent<ReadText>().filename = brokenCarBeforeInspection_Robbie;
            robbieTouch = true;
        }
        //Yvette's line
        //If yvette is touching the car,she hasn't touched the car yet, and e is being pressed
        //if (gameObject.GetComponent<carCheckFix>().yvetteTouching && !yvetteTouch && GameObject.Find("controlPlayerActive").GetComponent<controlPlayerActive>().isActiveName() == "Yvette" && Input.GetKey("e"))
        if (yvetteTouching && !yvetteTouch && GameObject.Find("controlPlayerActive").GetComponent<controlPlayerActive>().isActiveName() == "Yvette" && Input.GetKey("e"))
        {
            gameObject.GetComponent<ReadText>().active = true;
            gameObject.GetComponent<ReadText>().filename = brokenCarBeforeInspection_Yvette;
            yvetteTouch = true;
        }

        //If caroline is touching the car, she's active, and e is being pressed
        if (carolineTouching && GameObject.Find("controlPlayerActive").GetComponent<controlPlayerActive>().isActiveName() == "Caroline" && Input.GetKey("e"))
        {
            gameObject.GetComponent<ReadText>().active = true;
            gameObject.GetComponent<ReadText>().filename = CarolineDetect_car;
            //Reset touching if she's activated
            resetTouching();
            //Caroline won't proceed until spacebar is pressed and her text is over
            carolineFixed = true;
        }
    }

    void resetTouching()
    {
        yvetteTouch = false;
        carolineTouch = false;
        robbieTouch = false;
    }

    //Checks if the Car has been fixed, if it was, this script should be disabled
    void checkCarFixed()
    {
        if (gameObject.GetComponent<carCheckFix>().carIsFixed == true)
            gameObject.GetComponent<carText>().enabled = false;
    }

    private void OnTriggerEnter2D(Collider2D player)
    {
        //Check if Caroline is touching the car
        if (player.name == "Caroline")
            carolineTouching = true;

        //Check if Robbie is touching the car
        else if (player.name == "Robbie")
            robbieTouching = true;

        else if (player.name == "Yvette")
            yvetteTouching = true;
    }

    private void OnTriggerExit2D(Collider2D player)
    {
        //Check if Caroline is touching the car
        if (player.name == "Caroline")
            carolineTouching = false;

        //Check if Robbie is touching the car
        else if (player.name == "Robbie")
            robbieTouching = false;

        //Check if Yvette is touching the car
        else if (player.name == "Yvette")
            yvetteTouching = false;
    }

}
