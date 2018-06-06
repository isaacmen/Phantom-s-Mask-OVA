using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hiddenpanel : MonoBehaviour {
    //Caroline Detect sounds
    public GameObject carolineDetect;

	public bool hidden = true;
    public bool found = false;
    public bool active;
	public GameObject left = null;
	public GameObject right = null;

	public Sprite OnSprite;
	public Sprite OffSprite;
    public Sprite FoundSprite;

	public AudioSource SFX;
	public AudioClip hinge;
	public AudioClip panel;
	public AudioClip click;

	private bool yvetteTouching = false;
	private bool robbieTouching = false;
	private bool carolineTouching = false;

	private bool timeron = false;
	private int bullshittimer = 0;
    private int bullshitcounter = 0;

	private bool opensound = true;

    //Textbox to read to
    private GameObject reader;

    void Start()
    {
        reader = GameObject.FindGameObjectWithTag("textbox");
		SFX = GameObject.Find ("SFX").GetComponent<AudioSource> ();
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

		if (carolineTouching && Input.GetKey ("e") && hidden && (GameObject.Find("controlPlayerActive").GetComponent<controlPlayerActive>().isActiveName() == "Caroline")) {
            reader.GetComponent<ReadText>().active = true;
            reader.GetComponent<ReadText>().filename = "CarolinePanelInteraction.txt";
            Destroy(carolineDetect);
            hidden = false;
            found = true;
			SFX.clip = hinge;
			SFX.Play ();
        }

        if (left.GetComponent<hiddenpanel>().found == true || right.GetComponent<hiddenpanel>().found == true)
        {
            if (bullshitcounter == 0)
            {
                hidden = false;
                found = true;
            }
        }

        if (yvetteTouching && Input.GetKey("e") && !hidden && found && (GameObject.Find("controlPlayerActive").GetComponent<controlPlayerActive>().isActiveName() == "Yvette"))
        {
            bullshitcounter++;
			PlaySound ("yvette");
        }

        if (!hidden && found && robbieTouching && Input.GetKey ("e") && (GameObject.Find("controlPlayerActive").GetComponent<controlPlayerActive>().isActiveName() == "Robbie")) {
			ChangeStatus ();
			PlaySound ("robbie");
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

	void PlaySound(string name) {
		if (name == "yvette" && opensound) {
			SFX.clip = panel;
			SFX.Play();
			opensound = false;
		} else if (name == "robbie" && !opensound) {
			SFX.clip = click;
			SFX.Play ();
		}
	}

}
