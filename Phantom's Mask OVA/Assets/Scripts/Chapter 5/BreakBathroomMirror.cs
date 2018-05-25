using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakBathroomMirror : MonoBehaviour {
    private bool isBreakable;
    private bool yvetteTouching;
    public GameObject lever;


	// Use this for initialization
	void Start () {
        isBreakable = false;
        yvetteTouching = false;
        lever.GetComponent<Renderer>().enabled= false;
        lever.GetComponent<BoxCollider2D>().enabled = false;
    }
	
	// Update is called once per frame
	void Update () {
        if (isBreakable)
            checkYvetteTouching();
    }

    void checkYvetteTouching()
    {
        if (yvetteTouching && Input.GetKey("e"))
        {
            if (GameObject.Find("controlPlayerActive").GetComponent<controlPlayerActive5people>().isActiveName() == "Yvette")
            {
                // Activate the renderer for the lever
                lever.GetComponent<Renderer>().enabled = true;
                lever.GetComponent<BoxCollider2D>().enabled = true;
                Destroy(gameObject);
            }
        }
    }

    void paintingSeen()
    {
        isBreakable = true;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Yvette")
            yvetteTouching = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.name == "Yvette")
            yvetteTouching = false;
    }
}
