using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer: MonoBehaviour
    
{
    public RectTransform transform_min;
    private float sec;

    public static Timer instance;
    public float LimitTime;
    public TMP_Text text_Timer;
    void Start()
    {
        transform_min.pivot = new Vector2(0.35f, 0.35f);
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
        sec = (LimitTime / 60f) * 360f;

        transform_min.localRotation = Quaternion.Euler(0f, 0f, -sec);
    }
  
}
