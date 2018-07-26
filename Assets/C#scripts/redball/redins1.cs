using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class redins1 : MonoBehaviour {
    public GameObject redgo;
    bool reddie;
    float x_dir;
    float initial_x;

    // Use this for initialization
    void Start()
    {
        reddie = true ;
        initial_x = transform.position.x;
        x_dir = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        // transform.Rotate(new Vector3(0, 90 * Time.deltaTime * 10f, 0));
        float new_x = transform.position.x + x_dir * 10.0f * Time.deltaTime;
        if ((x_dir < 0 && new_x <= initial_x - 23.0f) || (x_dir > 0 && new_x >= initial_x))
            x_dir *= -1.0f;
        transform.position = new Vector3(new_x, transform.position.y, transform.position.z);
        if (reddie)
        {
            Instantiate(redgo, transform.position, transform.rotation);
            reddie = false;
            StartCoroutine(come());
        }
    }
    IEnumerator come()
    {
        yield return new WaitForSeconds(2f);
        reddie = true;
    }
}
