using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hiddenpanel : MonoBehaviour {

	public bool hidden = true;
    public bool found = false;
    public bool active;
	public GameObject left = null;
	public GameObject right = null;

	public Sprite OnSprite;
	public Sprite OffSprite;
    public Sprite FoundSprite;

	private bool yvetteTouching = false;
	private bool robbieTouching = false;
	private bool carolineTouching = false;

	private bool timeron = false;
	private int bullshittimer = 0;
    private int bullshitcounter = 0;

    //Textbox to read to
    private GameObject reader;

    void Start()
    {
        reader = GameObject.FindGameObjectWithTag("textbox");
    }

    // Update is called once per frame
    void Update () {
		if (timeron) {
			bullshittimer++;
		}
		if (bullshittimer > 60) {
			bullshittimer = 0;
			timeron = false;
		}

		ChangeSprite ();

		if (carolineTouching && Input.GetKey ("e") && hidden) {
            reader.GetComponent<ReadText>().active = true;
            reader.GetComponent<ReadText>().filename = "CarolinePanelInteraction.txt";
            hidden = false;
            found = true;
        }

        if (left.GetComponent<hiddenpanel>().found == true || right.GetComponent<hiddenpanel>().found == true)
        {
            if (bullshitcounter == 0)
            {
                hidden = false;
                found = true;
            }
        }

        if (yvetteTouching && Input.GetKey("e") && !hidden && found)
        {
            bullshitcounter++;
        }

        if (!hidden && found && robbieTouching && Input.GetKey ("e")) {
			ChangeStatus ();
		}
	}


	void ChangeStatus () {
		if (bullshittimer == 0) {
			this.active = !this.active;
			if (left != null) {
				left.GetComponent<hiddenpanel>().active = !left.GetComponent<hiddenpanel>().active;
			}
			if (right != null) {
				right.GetComponent<hiddenpanel>().active = !right.GetComponent<hiddenpanel>().active;
			}
			timeron = true;
		}
	}

	// checks status of panel and changes sprite accordingly
	void ChangeSprite () {
		if (!hidden && found && active && bullshitcounter != 0) {
			gameObject.GetComponent<SpriteRenderer> ().sprite = OnSprite;
		} else if (!hidden && found && !active && bullshitcounter != 0) {
			gameObject.GetComponent<SpriteRenderer>().sprite = OffSprite;
		} else if (!hidden && found) {
            gameObject.GetComponent<SpriteRenderer>().sprite = FoundSprite;
        }
	}


	// detects if players are touching
	private void OnTriggerEnter2D(Collider2D player)
	{
		if (player.name == "Caroline") {
			carolineTouching = true;
		} else if (player.name == "Robbie") {
			robbieTouching = true;
		} else if (player.name == "Yvette") {
			yvetteTouching = true;
		} 
	}

	private void OnTriggerExit2D(Collider2D player)
	{
		if (player.name == "Caroline") {
			carolineTouching = false;
		} else if (player.name == "Robbie") {
			robbieTouching = false;
		} else if (player.name == "Yvette") {
			yvetteTouching = false;
		} 
	}

}
