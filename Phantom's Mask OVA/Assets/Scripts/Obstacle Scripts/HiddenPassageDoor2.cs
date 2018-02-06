using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*Is paired with HiddenPassage script. Controls the 2nd door in the hidden passage*/
public class HiddenPassageDoor2 : MonoBehaviour {

    public GameObject door1; //door 1

    void OnTriggerStay2D(Collider2D player)
    {
        //If door2 isn't invisible
        if(gameObject.GetComponent<Renderer>().enabled == true)
        {
            if (Input.GetKeyDown("w"))
            {
                //player is transported to door 1
                player.gameObject.transform.position = new Vector3(door1.transform.position.x, door1.transform.position.y, door1.transform.position.z);
            }
        }
    }
}
