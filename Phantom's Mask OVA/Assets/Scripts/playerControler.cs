using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControler : MonoBehaviour {

    private Rigidbody2D myRigidbody;
    public bool grounded;
    public bool climbing;
	private Animator animator;

    [SerializeField]
    private float speed;
    private GameObject reader;

	// Use this for initialization
	void Start () {
        myRigidbody = GetComponent<Rigidbody2D>();
        grounded = true;
        climbing = false;
        reader = GameObject.FindGameObjectWithTag("textbox");
		//animator = this.GetComponent<Animator>();
		
    }
	
	// Update is called once per frame
	void Update () {
        float horizontal = Input.GetAxis("Horizontal");
        handleMovement(horizontal);
		if (Input.GetKeyDown("space") && grounded)
            myRigidbody.AddForce(new Vector2(0, 6), ForceMode2D.Impulse);
        handleClimbing();
    }

    private void handleClimbing()
    {
        //Debug.Log(climbing);
        if ((Input.GetKey("w")) && climbing)
        {
            transform.Translate(0, 5 * Time.deltaTime, 0);
        }
        else if ((Input.GetKey("s")) && climbing)
        {
            transform.Translate(0, -5 * Time.deltaTime, 0);
        }
    }

    private void handleMovement(float horizontal)
	{
        if (Input.GetKey("d"))
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);
			//animator.SetInteger("Direction", 1);
        }

        else if (Input.GetKey("a"))
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);
			//animator.SetInteger("Direction", 2);
        }
		else{
			//animator.SetInteger("Direction", 0);
		}
        


       // myRigidbody.velocity = new Vector2 (horizontal * speed, myRigidbody.velocity.y); //x-val -1, y-val 0

    }

}
