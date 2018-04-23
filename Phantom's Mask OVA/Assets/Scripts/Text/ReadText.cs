using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;


public class ReadText : MonoBehaviour {

	//this is the text file being read
    //the text handling scrips will manipulate this variable based on what needs to be displayed
	public string filename;
    //The path that contains the file ex: Assets/Text/ 
    //The path will be different for different objects, helps with organization
    public string pathFolder;

	//this is the text UI element being read to
	public UnityEngine.UI.Text Displaytext;
	public UnityEngine.UI.Image Textbox;

	//this is if the text is active
	public bool active = false;

	private string[] lines;
	private int max;
	private int currentline = 0;

    //Keeps track if a new file has to be reread. Happens the instant active changes fron false to true. Resets afterwards.
    private bool readFile = true;


	//gets lines from file and 
	string[] GetLines (string filename) {
		string path = pathFolder + filename;
		string[] result = File.ReadAllLines (path);

		return result;
	}
		

	// Use this for initialization
	void Start ()
    {
	}
	
	// Update is called once per frame
	void Update () {
		if (active) {

            getlines();

			if (currentline == 0)
			{
				Displaytext.text = lines[currentline];
				currentline++;
			}

			else if (currentline < max && Input.GetKeyDown("space"))
            {
                 Displaytext.text = lines[currentline];
                 currentline++;
            }

            else if (currentline >= max && Input.GetKeyDown("space"))
            {
                Displaytext.text = "";
                currentline = 0; //reset the current line
                readFile = true;
                active = false;
                //Let the player swap chars again
                GameObject.Find("controlPlayerActive").GetComponent<controlPlayerActive>().enabled = true;
            }
		}

		if (Displaytext.text != "") {
			Textbox.gameObject.SetActive (true);
		} else {
			Textbox.gameObject.SetActive (false);
		}
	}

    void getlines()
    {
        if (readFile)
        {
            lines = GetLines(filename);
            max = lines.Length;
            readFile = false;
            //Disable the script to swap chars
            GameObject.Find("controlPlayerActive").GetComponent<controlPlayerActive>().enabled = false;
        }
        //Displaytext.text = "";
    }

    


}
