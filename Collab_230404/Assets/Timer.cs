using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer: MonoBehaviour
    
{
    public static Timer instance;
    public float LimitTime;
    public TMP_Text text_Timer;
    void Awake()
    {
        if(Timer.instance==null)
        {
            Timer.instance = this;
        }
    }
    // Update is called once per frame
    void Update()
    {
  
        LimitTime += Time.deltaTime;
        text_Timer.text = "Time:" + Mathf.Round(LimitTime).ToString();
    }
}
