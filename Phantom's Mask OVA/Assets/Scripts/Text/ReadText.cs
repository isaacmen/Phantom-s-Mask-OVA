using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;


public class ReadText : MonoBehaviour {

	public string filename;
	public UnityEngine.UI.Text Displaytext;

	private string[] lines;
	private int max;
	private int currentline = 0;

	string[] GetLines (string filename) {
		string path = "Assets/Text/" + filename;
		string[] result = File.ReadAllLines (path);

		return result;
	}
		

	// Use this for initialization
	void Start () {
		lines = GetLines (filename);
		max = lines.Length;
		Displaytext.text = "";
	}
	
	// Update is called once per frame
	void Update () {
		if (currentline < max && Input.GetKeyDown ("space")) {
			Displaytext.text = lines [currentline];
			currentline++;
		} else if (currentline >= max && Input.GetKeyDown ("space")) {
			Displaytext.text = "";
		}
	}
}
