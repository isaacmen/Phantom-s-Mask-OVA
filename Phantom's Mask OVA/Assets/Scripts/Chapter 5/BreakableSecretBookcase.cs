using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakableSecretBookcase : MonoBehaviour {

    //Whether Yvette is touching this object or not
    private bool breakable;
    private bool yvetteTouching;
    private bool christopherTouching;
    private bool carolineTouching;
    private bool veronicaTouching;
    private bool robbieTouching;

    // Use this for initialization
    void Start()
    {
        breakable = false;
        yvetteTouching = false;
    }

    // Update is called once per frame
    void Update()
    {
        string currentlyActive = GameObject.Find("controlPlayerActive").GetComponent<controlPlayerActive5people>().isActiveName();
        if (!breakable)
        {
            if (yvetteTouching && (currentlyActive.Equals("Yvette")) && Input.GetKey("e"))
                GameObject.Find("LevelText").GetComponent<Lvl5Text>().SecretBookcaseInteract("Yvette (No Painting)");
            interactions(currentlyActive);
        }
        if(breakable)
            checkObjectBroke(currentlyActive);
    }

    private void interactions(string currentlyActive)
    {
        if (Input.GetKey("e"))
        {
            if (christopherTouching && (currentlyActive.Equals("Brian")))
                GameObject.Find("LevelText").GetComponent<Lvl5Text>().SecretBookcaseInteract("Christopher");
            else if (carolineTouching && (currentlyActive.Equals("Caroline")))
                GameObject.Find("LevelText").GetComponent<Lvl5Text>().SecretBookcaseInteract("Caroline");
            else if (veronicaTouching && (currentlyActive.Equals("Veronica")))
                GameObject.Find("LevelText").GetComponent<Lvl5Text>().SecretBookcaseInteract("Veronica");
            else if (robbieTouching && (currentlyActive.Equals("Robbie")))
                GameObject.Find("LevelText").GetComponent<Lvl5Text>().SecretBookcaseInteract("Robbie");
        }
    }

    public void isBreakable()
    {
        breakable = true;
    }
    public void checkObjectBroke(string currentlyActive)
    {
        interactions(currentlyActive);
        if (yvetteTouching == true && Input.GetKey("e"))
        {
            if (currentlyActive == "Yvette")
            {
                //GameObject.Find("LevelText").GetComponent<Lvl5Text>().SecretBookcaseInteract("Yvette");
                Destroy(gameObject);
            }
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Yvette")
            yvetteTouching = true;
        if (collision.name == "Robbie")
            robbieTouching = true;
        if (collision.name == "Caroline")
            carolineTouching = true;
        if (collision.name == "Veronica")
            veronicaTouching = true;
        if (collision.name == "Brian")
            christopherTouching = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.name == "Yvette")
            yvetteTouching = false;
        if (collision.name == "Robbie")
            robbieTouching = false;
        if (collision.name == "Caroline")
            carolineTouching = false;
        if (collision.name == "Veronica")
            veronicaTouching = false;
        if (collision.name == "Brian")
            christopherTouching = false;
    }
}
