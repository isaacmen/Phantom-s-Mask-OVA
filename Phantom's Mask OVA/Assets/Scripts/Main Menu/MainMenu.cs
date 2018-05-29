using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour {

    public GameObject music;

    public void playGame()
    {
        StartCoroutine(changeLevel());
    }


    public void quitGame()
    {
        Debug.Log("Quit Game");
        Application.Quit();
    }

    IEnumerator changeLevel()
    {

            float fadeTime = GameObject.Find("Fade").GetComponent<Fading>().BeginFade(1);
            while(music.GetComponent<AudioSource>().volume >= 0)
            {
                 if (music.GetComponent<AudioSource>().volume <= 0)
                     break;
                 //Debug.Log(music.GetComponent<AudioSource>().volume);
                 yield return new WaitForSeconds(0.1f);
                music.GetComponent<AudioSource>().volume -= 0.04f;
            }
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
