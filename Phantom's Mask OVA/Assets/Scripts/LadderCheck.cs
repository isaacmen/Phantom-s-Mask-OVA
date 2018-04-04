using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LadderCheck : MonoBehaviour
{

    private playerControler player;
    private Rigidbody2D rb;
    // Use this for initialization
    void Start()
    {
        player = gameObject.GetComponentInParent<playerControler>();
        rb = gameObject.GetComponentInParent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("ladder"))
        {
            rb.gravityScale = 0;
            player.climbing = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("ladder"))
        { 
            rb.gravityScale = 1;
            player.climbing = false;
        }
    }
}

