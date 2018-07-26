using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blueins : MonoBehaviour
{
    public GameObject bluego;
    bool die;
    float x_dir;
    float initial_x;

    // Use this for initialization
    void Start()
    {
        die = true;
        initial_x = transform.position.x;
        x_dir = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        // transform.Rotate(new Vector3(0, 90 * Time.deltaTime * 10f, 0));
        float new_x = transform.position.x + x_dir * 10.0f * Time.deltaTime;
        if ((x_dir < 0 && new_x <= initial_x ) || (x_dir > 0 && new_x >= initial_x + 23.0f))
            x_dir *= -1.0f;
        transform.position = new Vector3(new_x, transform.position.y, transform.position.z);
        if (die)
        {
            Instantiate(bluego, transform.position, transform.rotation);
            die = false;
            StartCoroutine(come());
        }
    }
    IEnumerator come()
    {
        yield return new WaitForSeconds(2f);
        die = true;
    }
}
