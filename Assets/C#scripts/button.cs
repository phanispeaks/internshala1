using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class button : MonoBehaviour
{
    public void onclick(string go)
    {
        SceneManager.LoadScene(go);
    }
    public void quit()
    {
        Application.Quit();
    }
}
