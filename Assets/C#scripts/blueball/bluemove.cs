﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bluemove : MonoBehaviour {
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "bullet")
            Destroy(gameObject);
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Destroy(gameObject, 7);
	}
}
