using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    public Text timerText;
    private float startTime;
    bool end = false;
    float time;
    string minutes;
    string seconds;

    // Use this for initialization
    void Start()
    {
        if (end == false)
        {
            startTime = Time.time;
        }
    }

    // Update is called once per frame
    void Update()
    {
         time = Time.time - startTime;

         minutes = ((int)time / 60).ToString();
         seconds = (time % 60).ToString("f2");

        timerText.text = minutes + ":" + seconds;
        
    }
    public float GetTime()
    {
        return time;
    }
}