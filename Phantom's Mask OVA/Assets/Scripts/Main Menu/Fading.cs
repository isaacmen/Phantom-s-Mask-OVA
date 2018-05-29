using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fading : MonoBehaviour {

    public Texture2D fadeOutTexture; //Will overlay the screen
    public float fadeSpeed = 0.08f; //Fading speed

    private int drawDepth = -1000; //Texture's order in the ddraw Heiarchy: a low number means it renders on top
    private float alpha = 1.0f;    //Texture's alpha value
    private int fadeDir = -1;      //Direction to fade: in = 1 or out = 1


    private void Start()
    {
        BeginFade(-1);
    }


    private void OnGUI()
    {
        alpha += fadeDir * fadeSpeed * Time.deltaTime;
        //Force the number between 0 and 1 because gui color uses alpha values between 0 and 1
        alpha = Mathf.Clamp01(alpha);

        //Set color of our GUI
        GUI.color = new Color(GUI.color.r, GUI.color.g, GUI.color.b, alpha);
        GUI.depth = drawDepth;   //black texture will render on top
        GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), fadeOutTexture);
    }

    //Sets fadeDir to the direction parameter making the scene fade in if -1 and out if 1
    public float BeginFade (int direction)
    {
        fadeDir = direction;
        return fadeSpeed;
    }

    //OnLevelWasLoaded is called when a level is loaded. It takes loaded level index (int) as a parameter so you can limit the fade in to cetrain scenes

}
