using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goBackScript : MonoBehaviour {

    public string level;

    public void changeLevel()
    {
        SceneManager.LoadScene(level);
    }
}
