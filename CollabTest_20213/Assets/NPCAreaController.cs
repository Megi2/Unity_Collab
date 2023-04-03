using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCAreaController : MonoBehaviour
{
    public GameObject panel;
    public GameObject nameTag;
    public GameObject player;
    private void Start()
    {
        panel.SetActive(false);
        nameTag = GameObject.Find("NameTag");
        nameTag.SetActive(false);
        
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        CharacterMove move = player.GetComponent<CharacterMove>();
        nameTag.SetActive(true);
        if(Input.GetKey(KeyCode.E))
        {
        panel.SetActive(true);
        move.enabled = false;
        }
        

    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        nameTag.SetActive(false);
    }
}
