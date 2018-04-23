using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxOnTop : MonoBehaviour
{

    private bool isInvisible; //Whether the button is invisible or not.
    private bool carolineTouching;


    // Use this for initialization
    void Start()
    {
        gameObject.GetComponent<Collider2D>().isTrigger = true;
        isInvisible = true;
        GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Kinematic;

        gameObject.GetComponent<Renderer>().enabled = false;
        //Disable this script until the button isn't invisible

    }

    // Update is called once per frame
    void Update()
    {
        if (isInvisible == true)
        {
            if (Input.GetKeyDown("e") && carolineTouching)
            {
                //Check Caroline is in control by checking the controlPlayerActive isActiveName function which returns string name of object in control. 
                if (GameObject.Find("controlPlayerActive").GetComponent<controlPlayerActive>().isActiveName() == "Caroline")
                {
                    gameObject.GetComponent<Renderer>().enabled = true;
                    gameObject.GetComponent<Collider2D>().isTrigger = false;
                    GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
                    isInvisible = false;
                }
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D player)
    {
        if (player.name == "Caroline")
        {
            Debug.Log("CAROLINEEE");
            carolineTouching = true;
        }
    }

    private void OnTriggerExit2D(Collider2D player)
    {
        if (player.name == "Caroline")
            carolineTouching = false;
    }

}
