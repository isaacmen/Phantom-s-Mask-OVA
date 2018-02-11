using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
 * Activated by carCheckFix after Caroline and Robbie interact with the car
 * Checks if all 3 people are in the car. If they are, the car can move.
 * Attatched to Car. Need to input the names of the players in this level AND the tree that it will crash against in level 1. Not complete.
 */
public class carMovement : MonoBehaviour {
    //Get current 3 active gameobjects
    public GameObject p1;
    public GameObject p2;
    public GameObject p3;
    public GameObject tree;

    private bool canMove = true;

    private bool p1inCar = false;
    private bool p2inCar = false;
    private bool p3inCar = false;

    private bool touchingp1 = false;
    private bool touchingp2 = false;
    private bool touchingp3 = false;


    // Use this for initialization
    void Start () {
        //disable carCheckFix script
        gameObject.GetComponent<carCheckFix>().enabled = false;
       }

    void Update()
    {
        //The car works and the car is touchign a player
        if (GameObject.Find("controlPlayerActive").GetComponent<controlPlayerActive>().isActiveName() == p1.name)
           check_p1();
        else if (GameObject.Find("controlPlayerActive").GetComponent<controlPlayerActive>().isActiveName() == p2.name)
           check_p2();
        else if (GameObject.Find("controlPlayerActive").GetComponent<controlPlayerActive>().isActiveName() == p3.name)
           check_p3();

        //Check if everyone is in the car and if the car is not touching the tree. If they are, the car can move
        if (inCar() == true && canMove == true)
           carMove();
    }

    private void OnTriggerEnter2D(Collider2D cplayer)
    {
             if (cplayer.name == p1.name)
                 touchingp1 = true;
             if (cplayer.name == p2.name)
                 touchingp2 = true;
             if (cplayer.name == p3.name)
                 touchingp3 = true;

            //If it touches the tree, the car can't move. Make the car bounce away from the wall!
            if (cplayer.name == tree.name)
            {
                canMove = false;
                //Find the direction it was going
                var force = transform.position - tree.transform.position;
                force.Normalize();
                GetComponent<Rigidbody2D>().AddForce(force * 100);
            }
    }

    private void OnTriggerExit2D(Collider2D cplayer)
    {
                if (cplayer.name == p1.name)
                    touchingp1 = false;
                if (cplayer.name == p2.name)
                    touchingp2 = false;
                if (cplayer.name == p3.name)
                    touchingp3 = false;
            //No longer touching the tree, can move
            if (cplayer.name == tree.name)
            {
                canMove = true;
                //Make it stop moving left
                GetComponent<Rigidbody2D>().velocity = Vector3.zero;
            }
    }

    //Controls the car's movement
    void carMove()
    {
        if (canMove == true)
        {
            if (Input.GetKey("a"))
                transform.Translate(-Vector3.right * 7 * Time.deltaTime);
            if (Input.GetKey("d"))
                transform.Translate(-Vector3.left * 7 * Time.deltaTime);
        }
       
    }
    //Check if everyone is in the car
    bool inCar()
    {
        if (p1inCar && p2inCar && p3inCar)
            return true;
        return false;
    }

    //Checks player 1 and if they are in the car and what to do based off that
    void check_p1()
    {
        //If it collided with p1 and space is being held and is not in car and is touching
        if (Input.GetKeyDown(KeyCode.Space) && p1inCar == false && touchingp1 == true)
        {
            //player is now in car
            p1inCar = true;
            //make player invisible
            p1.GetComponent<Renderer>().enabled = false;
            p1.GetComponent<playerControler>().enabled = false;
        }

        //p1 is active and in the car
        else if (p1inCar == true && Input.GetKeyDown(KeyCode.Space))
        {
            //move position to car position
            p1.gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, 0);
            //make it visible
            p1.GetComponent<Renderer>().enabled = true;
            p1.GetComponent<playerControler>().enabled = true;
            //they're not in the car
            p1inCar = false;
        }
    }

    void check_p2()
    {
        //If it collided with p1 and space is being held and is not in car and is touching
        if (Input.GetKeyDown(KeyCode.Space) && p2inCar == false && touchingp2 == true)
        {
            //player is now in car
            p2inCar = true;
            //make player invisible
            p2.GetComponent<Renderer>().enabled = false;
            p2.GetComponent<playerControler>().enabled = false;
        }

        //p1 is active and in the car
        else if (p2inCar == true && Input.GetKeyDown(KeyCode.Space))
        {
            //move position to car position
            p2.gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, 0);
            //make it visible
            p2.GetComponent<Renderer>().enabled = true;
            p2.GetComponent<playerControler>().enabled = true;
            //they're not in the car
            p2inCar = false;
        }
    }

    void check_p3()
    {
        //If it collided with p1 and space is being held and is not in car and is touching
        if (Input.GetKeyDown(KeyCode.Space) && p3inCar == false && touchingp3 == true)
        {
            //player is now in car
            p3inCar = true;
            //make player invisible
            p3.GetComponent<Renderer>().enabled = false;
            p3.GetComponent<playerControler>().enabled = false;
        }

        //p1 is active and in the car
        else if (p3inCar == true && Input.GetKeyDown(KeyCode.Space))
        {
            //move position to car position
            p3.gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, 0);
            //make it visible
            p3.GetComponent<Renderer>().enabled = true;
            p3.GetComponent<playerControler>().enabled = true;
            //they're not in the car
            p3inCar = false;
        }
    }

}
