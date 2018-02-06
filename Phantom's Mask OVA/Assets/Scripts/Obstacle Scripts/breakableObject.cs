using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Added to objects that Yvette can break. These objects are destroyed. */
public class breakableObject : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionStay2D(Collision2D player)
    {
        //Check if Yvette is touching the object and if e is being pressed
        if (player.gameObject.name == "Yvette" && Input.GetKeyDown("e"))
        {
            //Check Yvette is active
            if (GameObject.Find("controlPlayerActive").GetComponent<controlPlayerActive>().isActiveName() == "Yvette")
            {
                //Destroy this box
                Destroy(gameObject);
            }
        }
    }
}
