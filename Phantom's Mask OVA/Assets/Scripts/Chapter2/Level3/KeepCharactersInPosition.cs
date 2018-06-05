using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Keeps characters in the same position after the scene change to scene 3a through the use of STATIC VARIABLE
 * Used at start
 **/
public class KeepCharactersInPosition : MonoBehaviour {

    public GameObject caroline;
    public GameObject robbie;
    public GameObject yvette;

    //Position vectors
    private static Vector3 carolinePos = new Vector3(-5.11f, -3.88f, -0.03671469f);
    private static Vector3 robbiePos = new Vector3(-6.351622f, -3.939013f, -0.006505899f);
    private static Vector3 yvettePos = new Vector3(-3.66f, -3.87f, -0.1279808f);

 


	// Use this for initialization
	void Start () {
        //Start off at the last position they were at
        caroline.transform.position = carolinePos;
        robbie.transform.position = robbiePos;
        yvette.transform.position = yvettePos;
	}
	
	// Update is called once per frame
	void Update () {
        //Update their position every frame
        carolinePos = caroline.transform.position;
        robbiePos = robbie.transform.position;
        yvettePos = yvette.transform.position;
	}
}
