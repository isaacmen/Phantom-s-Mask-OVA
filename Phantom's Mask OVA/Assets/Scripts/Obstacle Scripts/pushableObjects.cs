using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* 
 * This script should be atatched to pushable objects, like boxes and such. 
 * Only Chris can push or pull these objects
 */
public class pushableObjects : MonoBehaviour {

    //Has to match Chris' speed
    public float speed;
    private bool chrisTouching = false;

    void Start()
    {
  
    }
 
    void Update()
    {
        
      if (chrisTouching == true && Input.GetKey("e"))
       // {
          if (GameObject.Find("controlPlayerActive").GetComponent<controlPlayerActive>().isActiveName() == "Chris")
                HandleMovement();
        
       // }
    }

    void HandleMovement()
    {
            if (Input.GetKey("a"))
            {
                transform.Translate(-speed * Time.deltaTime, 0, 0);
            }

            if (Input.GetKey("d"))
            {
                transform.Translate(speed * Time.deltaTime, 0, 0);
            }
    }

    void OnCollisionEnter2D(Collision2D player)
    {
        if(player.gameObject.name == "Chris")
             chrisTouching = true;
        Debug.Log("Touching");
    }

    void OnCollisionExit2D(Collision2D player)
    {
        if (player.gameObject.name == "Chris")
            chrisTouching = false;
        Debug.Log("HEYYYY");
    }


}
