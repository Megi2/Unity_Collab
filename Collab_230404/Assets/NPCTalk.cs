using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public struct TalkData
{
    public string name;
    public string[] contexts;

}
public class NPCTalk : MonoBehaviour
{
    public GameObject TalkPanel;
    // Start is called before the first frame update
    void Start()
    {
        TalkPanel.SetActive(false);
        List<Dictionary<string, object>> Talk_Dialogue = CSVReader.Read("Dialogue");
        NPCAreaController NAC = new NPCAreaController();
        for (int i = 0; i < Talk_Dialogue.Count; i++)
        {
            Debug.Log(Talk_Dialogue[i]["text"].ToString());
        }
        NAC.Talk += new EventHandler(StartTalk);
    }

    void StartTalk(object sender, EventArgs e)
    {
        TalkPanel.SetActive(true);
        Debug.Log("recieved");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
