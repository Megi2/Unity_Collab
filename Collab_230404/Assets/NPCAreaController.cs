using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public delegate void TalkEvent(int i);
public class NPCAreaController : MonoBehaviour
{
    public GameObject panel;
    public GameObject nameTag;
    public GameObject player;
    public NPCSet NPC;
    public event EventHandler Talk;

public void TalkEvent()
    {
        Debug.Log("Event func call1");
        if (this.Talk != null)
        {
            Debug.Log("Event func call2");
            Talk(this, EventArgs.Empty);
        }   
    }

private void Start()
    {
        nameTag = GameObject.Find("NameTag");
        nameTag.SetActive(false);
        NPC = this.GetComponent<NPCSet>();
        
    }
    private void OnCollisionStay2D(Collision2D collision)
    {   
        CharacterMove move = player.GetComponent<CharacterMove>();
        nameTag.SetActive(true);
        if(Input.GetKey(KeyCode.E))
        {
            move.enabled = false;
            TalkEvent();
        }
        

    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        nameTag.SetActive(false);
    }
}
