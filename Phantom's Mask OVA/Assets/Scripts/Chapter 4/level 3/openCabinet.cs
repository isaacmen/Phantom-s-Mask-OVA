using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openCabinet : MonoBehaviour {
    private bool VeronicaFoundKey;

    private bool someoneIsColliding;
	// Use this for initialization
	void Start () {
        VeronicaFoundKey = false;
 
	}

    public void SetVeronicaFoundKey()
    {
        VeronicaFoundKey = true;
    }

    public void OpentheCabinet()
    {
        if (VeronicaFoundKey == true)
        {
            if (Input.GetKeyDown("e"))
            {
                //They got the toolbox, can fix the fridge now
                GameObject.Find("Fridge").GetComponent<FixFridge>().SetFoundToolbox();
            }
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == GameObject.Find("PlayerController").GetComponent<controlPlayerActive>().isActiveName())
            OpentheCabinet();
    }

    public void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.name == GameObject.Find("PlayerController").GetComponent<controlPlayerActive>().isActiveName())
            OpentheCabinet();
    }
}
