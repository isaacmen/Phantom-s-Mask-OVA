using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ch1lvl3SFX : MonoBehaviour {
	public AudioClip computer; 
	public AudioClip debris; 

	private AudioSource soundplayer;

	void Start () {
		soundplayer = this.GetComponent<AudioSource> ();
	}

	public void ComputerSound() {
		soundplayer.clip = computer;
		soundplayer.Play ();
	}

	public void DebrisSound() {
		soundplayer.clip = debris;
		soundplayer.Play ();
	}

}
