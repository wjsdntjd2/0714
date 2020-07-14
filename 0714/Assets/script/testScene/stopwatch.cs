using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class stopwatch : MonoBehaviour
{
    float Timer;
    float D;
    float S;
    float M;
    public Text StopWatch;

    private void Start()
    {
        Timer = 0;
    }
    void Update()
    {
        Timer += Time.deltaTime;
        S = (int)(Timer % 60);
        M = (int)(Timer / 60);
        D = (int)((Timer - (S + M)) * 100);
        //StopWatch.text = M.ToString()+ ":" + S.ToString() + ":" + D.ToString();
        StopWatch.text = string.Format("{0:00}:{1:00}:{2:00}", M, S, D);
    }
}
