using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
