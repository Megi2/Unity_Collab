using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public delegate void TalkEvent(int i);
public class NPCAreaController : MonoBehaviour
{
    public GameObject panel;
    public GameObject nameTag;
    public NPCSet NPC;
    //public event EventHandler Talk;
    public UnityEvent Talk;

public void TalkEvent()
    {
        Talk.Invoke();
    }

private void Start()
    {
        nameTag = GameObject.Find("NameTag");
        nameTag.SetActive(false);
        
    }
    private void OnCollisionStay2D(Collision2D collision)
    {   
        nameTag.SetActive(true);
        if(Input.GetKeyDown(KeyCode.E))
        {
            TalkEvent();
        }
        

    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        nameTag.SetActive(false);
    }
}
