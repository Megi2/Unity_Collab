using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Door : MonoBehaviour
{

   
    [SerializeField] private GameObject Loading;
    public float Loadingtime;
    public float Endtime;
    public bool SceneTrue=false;

    void Update()
    {
       
        if (SceneTrue == true)
        {
            Loadingtime += Time.deltaTime;
            if (Loadingtime>2)
            {
                Loadingtime = 0;
                LoadingExit();
            }
        }
        
    }

    private void OnCollisionStay2D(Collision2D other)
    {
        Debug.Log("Hello Unity!");
        switch (other.gameObject.tag)//스위치문 이용
        {
            
            case "Door1": {
             float time1 = Timer.instance.LimitTime;
                    if (time1> 30){//특정 시간 넘어가야 문 열림
                        transform.position = new Vector2(25, 0);
                        LoadingShow();
                    }
                    break;
                }

            case "Door2":
                {
                    transform.position = new Vector2(3, 0);
                    LoadingShow();
                    break;
                }


        }

        }
    private void OnCollisionExit2D(Collision2D collision)
    {
        
    }

    public void LoadingShow()
    {
        print("show");
        Loading.SetActive(true);
        //Endtime = Loadingtime;
        SceneTrue = true;

        /* while (true)
         {
             Loadingtime += Time.deltaTime;
             print("loading");
            if (Mathf.Round(Loadingtime) >3000)
             {
                 Loading.SetActive(false);
                 Loadingtime = 0;
                 Endtime = 0;
                 break;
             }
         }*/

    }


    public void LoadingExit()
    {
        
        Loading.SetActive(false);
        SceneTrue = false;
    }
    }

