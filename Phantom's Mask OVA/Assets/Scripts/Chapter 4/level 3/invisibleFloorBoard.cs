using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class invisibleFloorBoard : MonoBehaviour {

	public GameObject tempchangescene;

    private bool CarolineTouching;
    private bool VeronicaTouching;
    private bool floorIsVisible;

	// Use this for initialization
	void Start () {
        //The floorboard is invisible at the start until Caroline touches it
        GetComponent<Renderer>().enabled = false;
        floorIsVisible = false;
        CarolineTouching = false;
        VeronicaTouching = false;
    }
	
	// Update is called once per frame
	void Update () {
        if (floorIsVisible == false)
            HandleCarolineInput();
        else
            HandleVeronicaInput();
		
	}


    public void HandleCarolineInput()
    {
        if (CarolineTouching && Input.GetKeyDown("e"))
        {
            if (GameObject.Find("PlayerController").GetComponent<controlPlayerActive>().isActiveName() == "Caroline")
            {
                GameObject.Find("TextScripts").GetComponent<Ch4Lvl3Text>().CarolineFoundFloorboard();
                GetComponent<Renderer>().enabled = true;
                floorIsVisible = true;
            }
        }
    }
    public void HandleVeronicaInput()
    {
        if (VeronicaTouching && Input.GetKeyDown("e"))
        {
            if (GameObject.Find("PlayerController").GetComponent<controlPlayerActive>().isActiveName() == "Veronica")
            {
                //Key recieved, can open cabinet now.
                GameObject.Find("TextScripts").GetComponent<Ch4Lvl3Text>().VeronicaPryFloorboard();
                GameObject.Find("Cabinet").GetComponent<openCabinet>().SetVeronicaFoundKey();
            }
			// idk when or how this scene is supposed to end
			// so i jus moved on here
			tempchangescene.GetComponent<changeScene> ().active = true;

        }
    }


    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Caroline")
            CarolineTouching = true;
        if (collision.name == "Veronica")
            VeronicaTouching = true;
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.name == "Caroline")
            CarolineTouching = false;
        if (collision.name == "Veronica")
            VeronicaTouching = false;
    }
}
