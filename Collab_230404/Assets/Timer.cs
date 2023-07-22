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
    void Start()
    {
        if (PlayerPrefs.HasKey("Lv"))
        {
            LimitTime = PlayerPrefs.GetFloat("Lv");
        }
        print("start");
    }
    void Awake()
    {
        if (Timer.instance == null)
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
