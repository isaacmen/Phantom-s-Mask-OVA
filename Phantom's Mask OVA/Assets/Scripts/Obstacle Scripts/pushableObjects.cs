using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* 
 * This script should be atatched to pushable objects, like boxes and such. 
 * Only Brian can push or pull these objects
 */
public class pushableObjects : MonoBehaviour {

    private float speed = 7;
    private bool brianTouching = false;
    private Rigidbody2D myRigidbody;

    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
    }
 
    void Update()
    {
        
      //  if (brianTouching == true  && Input.GetKeyDown("e"))
       // {
          if (GameObject.Find("controlPlayerActive").GetComponent<controlPlayerActive>().isActiveName() == "Brian")
                HandleMovement();
        
       // }
    }

    void HandleMovement()
    {
        float horizontal = Input.GetAxis("Horizontal");
        Debug.Log("WOOOOOO");
        myRigidbody.velocity = new Vector2(horizontal * speed, myRigidbody.velocity.y);
    }

    void OnCollisionEnter2D(Collision2D player)
    {
        if(player.gameObject.name == "Brian")
             brianTouching = true;
    }

    void OnCollisionExit2D(Collision2D player)
    {
        if (player.gameObject.name == "Brian")
            brianTouching = false;
    }


}
