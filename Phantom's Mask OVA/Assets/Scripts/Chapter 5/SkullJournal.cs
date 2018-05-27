using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkullJournal : MonoBehaviour {
    private ArrayList touching;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        touching.Add(collision.name);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        touching.Remove(collision.name);
    }
}
