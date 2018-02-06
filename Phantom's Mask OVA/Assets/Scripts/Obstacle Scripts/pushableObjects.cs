using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* 
 * This script should be atatched to pushable objects, like boxes and such. 
 * Only Jonathan(? I think it's his special ability, might change) can push or pull these objects
 */
public class pushableObjects : MonoBehaviour {

    private float speed = 7;
    private bool canMove = false;
    private Rigidbody2D myRigidbody;

    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
    }
 
    void Update()
    {
        
        if (canMove == true)
        {
            if (Input.GetKey("a"))
                transform.Translate(-Vector3.right * speed * Time.deltaTime);
            if (Input.GetKey("d"))
                transform.Translate(-Vector3.left * speed * Time.deltaTime);
            /*
            Debug.Log("I can move\n");
            GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None;
            float horizontal = Input.GetAxis("Horizontal");
            HandleMovement(horizontal);
            */
        }
    }

    void HandleMovement(float horizontal)
    {
        myRigidbody.velocity = new Vector2(horizontal * speed, myRigidbody.velocity.y);
    }

    void OnCollisionStay2D(Collision2D player)
    {
        //If Jonathan is touching it and spacebar is being presed
        canMove = true;
        /*
        Debug.Log("Collision\n");
        if (player.gameObject.name == "Jonathan" && Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Pushing\n");
            //Check Jonathan is in control, that way the box won't move if
            //Someone else in in control and Jonathan is touching the box
            if (GameObject.Find("controlPlayerActive").GetComponent<controlPlayerActive>().isActiveName() == "Jonathan")
            {
                canMove = true;
            }
            else
            {
                canMove = false;
                GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;
            }
        }
        */
    }

    void OnCollisionExit2D(Collision2D player)
    {
       // canMove = false;
       // GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;
    }


}
