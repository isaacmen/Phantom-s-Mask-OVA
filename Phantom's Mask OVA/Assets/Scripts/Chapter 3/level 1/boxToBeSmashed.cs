using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class boxToBeSmashed : MonoBehaviour {

    public GameObject willSmashThis;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == willSmashThis)
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
         }
    }
}
