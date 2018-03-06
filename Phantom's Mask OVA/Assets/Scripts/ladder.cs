using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ladder : MonoBehaviour {

    private static float speed = 5;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerStay2D(Collider2D player)
    {
        //They pressed up
        if(Input.GetKey("w"))
        {
            //player.GetComponent<Rigidbody2D>().velocity = new Vector2(0, speed);
            player.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 1), ForceMode2D.Impulse);
        }

        //Go down
        else if(Input.GetKey("s"))
        {
            // player.GetComponent<Rigidbody2D>().velocity = new Vector2(0, -speed);
            player.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, -1), ForceMode2D.Impulse);
        }

        //Anything else, don't move
        else
        {
            player.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        }
    }
}
