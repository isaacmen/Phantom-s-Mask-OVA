using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Added to objects that Yvette can break. These objects are destroyed. */
public class breakableObject : MonoBehaviour {

    private bool yvetteTouching = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (yvetteTouching == true && Input.GetKeyDown("e"))
        {
            //Check Yvette is active
            if (GameObject.Find("controlPlayerActive").GetComponent<controlPlayerActive>().isActiveName() == "Yvette")
            {
                //Destroy this box
                Destroy(gameObject);
            }
        }

    }

    void OnCollisionEnter2D(Collision2D player)
    {
        if(player.gameObject.name == "Yvette")
            yvetteTouching = true;
    }

    private void OnCollisionExit2D(Collision2D player)
    {
        if (player.gameObject.name == "Yvette")
            yvetteTouching = false;
    }

}
