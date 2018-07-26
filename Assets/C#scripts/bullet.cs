using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bullet : MonoBehaviour
{
    Rigidbody2D myrb;
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "blueball")
        {
            player.score += 5;
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "redball")
        {
            player.score += 15;
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "greenball")
        {
            player.score += 10;
            Destroy(gameObject);
        }
    }
    // Use this for initialization
    void Start()
    {
        myrb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        myrb.velocity = new Vector2(0f, 30f);
        Destroy(gameObject, 0.7f);
    }
}