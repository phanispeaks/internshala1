using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour
{
    Rigidbody2D myrb;
    public static int score;
    public GameObject bull;
    bool fire;
    public Text timetext;
    public Text scoretext;
    int timelimit;
    bool rightaction,leftaction;
    // Use this for initialization
    void Start()
    {
        myrb = GetComponent<Rigidbody2D>();
        score = 0;
        timelimit = 30;
        StartCoroutine(goo());
        StartCoroutine("onesec");
    }

    // Update is called once per frame
    void Update()
    {
        
        
        if (rightaction)
        {
            rightaction = false;
            myrb.velocity = new Vector2(10f, 0);
            
        }
        if (leftaction)
        {
            leftaction = false;
            myrb.velocity = new Vector2(-10f, 0);
            
            
        }
        if (fire)
        {
            Instantiate(bull, transform.position, transform.rotation);
            fire = false;
        }
        scoretext.text = "points:"+ score.ToString();
        timetext.text = timelimit.ToString();
        if (timelimit <= 0)
        {
            SceneManager.LoadScene("gameOver");
        }
    }
    IEnumerator goo()
    {
        while(true)
        {
            yield return new WaitForSeconds(0.3f);
            fire = true;
        }
    }
    IEnumerator onesec()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            timelimit--;

        }
    }
   public void rightclicked()
    {
        rightaction = true;
    }
    public void leftclicked()
    {
        leftaction = true;
    }
}
