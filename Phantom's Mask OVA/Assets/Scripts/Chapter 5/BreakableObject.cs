using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakableObject : MonoBehaviour {

    //Whether Yvette is touching this object or not
    private bool yvetteTouching;

	// Use this for initialization
	void Start () {
        yvetteTouching = false;
	}

    // Update is called once per frame
    void Update()
    {
        checkObjectBroke();
    }

    public void checkObjectBroke()
    {
        if(yvetteTouching == true && Input.GetKey("e"))
        {
            if (GameObject.Find("controlPlayerActive").GetComponent<controlPlayerActive5people>().isActiveName() == "Yvette")
                Destroy(gameObject);
        }
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
