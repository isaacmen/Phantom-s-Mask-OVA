using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallNote : MonoBehaviour {

    private const string DiaryEntry = "Diary Entry.txt";


    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == GameObject.Find("PlayerController").GetComponent<controlPlayerActive>().isActiveName())
        {
            if (Input.GetKeyDown("e"))
            {
                GameObject.Find("txtreader").GetComponent<ReadText>().active = true;
                GameObject.Find("txtreader").GetComponent<ReadText>().pathFolder = DiaryEntry;
            }
        }
    }

    public void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.name == GameObject.Find("PlayerController").GetComponent<controlPlayerActive>().isActiveName())
        {
            if (Input.GetKeyDown("e"))
            {
                GameObject.Find("txtreader").GetComponent<ReadText>().active = true;
                GameObject.Find("txtreader").GetComponent<ReadText>().pathFolder = "Assets/Texts/Chapter 4/Level 3/";
                GameObject.Find("txtreader").GetComponent<ReadText>().filename = DiaryEntry;
            }
        }
    }
}
