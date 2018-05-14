using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ch4Lvl3Text : MonoBehaviour {

    public void CarolineFoundFloorboard()
    {
        GameObject.Find("txtreader").GetComponent<ReadText>().active = true;
        GameObject.Find("txtreader").GetComponent<ReadText>().pathFolder = "Assets/Texts/Chapter 4/Level 3/";
        GameObject.Find("txtreader").GetComponent<ReadText>().filename = "Caroline Floorboard.txt";
    }

    public void VeronicaPryFloorboard()
    {
        GameObject.Find("txtreader").GetComponent<ReadText>().active = true;
        GameObject.Find("txtreader").GetComponent<ReadText>().pathFolder = "Assets/Texts/Chapter 4/Level 3/";
        GameObject.Find("txtreader").GetComponent<ReadText>().filename = "Veronica Cabinet and Floorboard.txt";
    }


}
