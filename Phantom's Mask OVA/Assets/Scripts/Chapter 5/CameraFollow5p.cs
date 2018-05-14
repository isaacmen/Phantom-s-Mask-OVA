using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow5p : MonoBehaviour
{

    public GameObject caroline;
    public GameObject robbie;
    public GameObject yvette;
    public GameObject brian;
    public GameObject veronica;
    public GameObject controller;

    // Update is called once per frame
    void Update()
    {
        if (controller.GetComponent<controlPlayerActive5people>().isActiveName() == "Robbie")
            MoveCamera(robbie);
        else if (controller.GetComponent<controlPlayerActive5people>().isActiveName() == "Caroline")
            MoveCamera(caroline);
        else if (controller.GetComponent<controlPlayerActive5people>().isActiveName() == "Yvette")
            MoveCamera(yvette);
        else if (controller.GetComponent<controlPlayerActive5people>().isActiveName() == "Brian")
            MoveCamera(brian);
        else if (controller.GetComponent<controlPlayerActive5people>().isActiveName() == "Veronica")
            MoveCamera(veronica);
    }

    void MoveCamera(GameObject player)
    {
        float playerX = player.transform.position.x;
        if (playerX > -6.12 && playerX < 24)
        {
            this.transform.position = new Vector3(playerX, 2f, -10.0f);
        }
        else if (playerX <= -6.12)
        {
            this.transform.position = new Vector3(-6.12f, 2f, -10.0f);
        }
        else if (playerX >= 24)
        {
            this.transform.position = new Vector3(6.12f, 2f, -10.0f);
        }
    }
}
