using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lvl5Text : MonoBehaviour {

    
    public void MirrorInteract(string name)
    {
        GameObject.Find("txtreader").GetComponent<ReadTextLvl5>().active = true;
        GameObject.Find("txtreader").GetComponent<ReadTextLvl5>().pathFolder = "Assets/Texts/Chapter 5/Level Text/";
        GameObject.Find("txtreader").GetComponent<ReadTextLvl5>().filename = "Mirror " + name + ".txt";
    }

    public void SecretBookcaseInteract(string name)
    {
        GameObject.Find("txtreader").GetComponent<ReadTextLvl5>().active = true;
        GameObject.Find("txtreader").GetComponent<ReadTextLvl5>().pathFolder = "Assets/Texts/Chapter 5/Level Text/";
        GameObject.Find("txtreader").GetComponent<ReadTextLvl5>().filename = "Bookcase " + name + ".txt";
    }

    public void RugInteract(string name)
    {
        GameObject.Find("txtreader").GetComponent<ReadTextLvl5>().active = true;
        GameObject.Find("txtreader").GetComponent<ReadTextLvl5>().pathFolder = "Assets/Texts/Chapter 5/Level Text/";
        GameObject.Find("txtreader").GetComponent<ReadTextLvl5>().filename = "Rug " + name + ".txt";
    }

    public void CouchInteract(string name)
    {
        GameObject.Find("txtreader").GetComponent<ReadTextLvl5>().active = true;
        GameObject.Find("txtreader").GetComponent<ReadTextLvl5>().pathFolder = "Assets/Texts/Chapter 5/Level Text/";
        GameObject.Find("txtreader").GetComponent<ReadTextLvl5>().filename = "Couch " + name + ".txt";
    }

    public void RopeInteract(string name)
    {
        GameObject.Find("txtreader").GetComponent<ReadTextLvl5>().active = true;
        GameObject.Find("txtreader").GetComponent<ReadTextLvl5>().pathFolder = "Assets/Texts/Chapter 5/Level Text/";
        GameObject.Find("txtreader").GetComponent<ReadTextLvl5>().filename = "Rope " + name + ".txt";

    }

}
