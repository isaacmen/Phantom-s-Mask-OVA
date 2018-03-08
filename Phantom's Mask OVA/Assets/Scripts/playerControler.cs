using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControler : MonoBehaviour {

    private Rigidbody2D myRigidbody;
    public bool grounded;

    [SerializeField]
    private float speed;

	// Use this for initialization
	void Start () {
        myRigidbody = GetComponent<Rigidbody2D>();
        grounded = true;
	}
	
	// Update is called once per frame
	void Update () {
        float horizontal = Input.GetAxis("Horizontal");
        handleMovement(horizontal);
		if (Input.GetKeyDown("up") && grounded)
        {
            myRigidbody.AddForce(new Vector2(0, 6), ForceMode2D.Impulse);
        }
    }

    private void handleMovement(float horizontal)
	{
			myRigidbody.velocity = new Vector2 (horizontal * speed, myRigidbody.velocity.y); //x-val -1, y-val 0

	}

}
