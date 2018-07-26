using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class wonscore : MonoBehaviour
{
    public Text displayscore;
    // Use this for initialization
    void Start()
    {
        displayscore.text = "your score " + player.score.ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }
}