using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AltarController : MonoBehaviour {
    //The Altars
    public GameObject altar1;
    public GameObject altar2;
    public GameObject altar3;

	// Use this for initialization
	void Start () {
        altar1.GetComponent<SpriteRenderer>().enabled = false;
        altar2.GetComponent<SpriteRenderer>().enabled = false;
        altar3.GetComponent<SpriteRenderer>().enabled = false;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void activateAltar(int altar)
    {
        if(altar == 1)
            altar1.GetComponent<SpriteRenderer>().enabled = true;
        if (altar == 2)
            altar2.GetComponent<SpriteRenderer>().enabled = true;
        if (altar == 3)
            altar3.GetComponent<SpriteRenderer>().enabled = true;
    }
}
