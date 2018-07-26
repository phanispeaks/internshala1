using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class redmove : MonoBehaviour {
    // Use this for initialization
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "bullet")
        Destroy(gameObject);
    }
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Destroy(gameObject, 7);
	}
}
