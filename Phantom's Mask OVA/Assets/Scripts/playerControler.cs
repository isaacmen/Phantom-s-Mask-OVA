using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControler : MonoBehaviour {

    private Rigidbody2D myRigidbody;

    [SerializeField]
    private float speed;

	// Use this for initialization
	void Start () {
        myRigidbody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        float horizontal = Input.GetAxis("Horizontal");
        handleMovement(horizontal);
    }

    private void handleMovement(float horizontal)
    {
        myRigidbody.velocity = new Vector2(horizontal * speed,myRigidbody.velocity.y); //x-val -1, y-val 0
    }
}
