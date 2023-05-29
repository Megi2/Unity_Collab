using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Events;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;

public struct TalkData
{
    public string name;
    public string[] contexts;

}
public class NPCTalk : MonoBehaviour
{
    [SerializeField]
    public GameObject TalkPanel;

    public Image portrait_image;
    public TextMeshProUGUI talk_text;
    public TextMeshProUGUI name_text;

    public GameObject player;
    public int count = 0;
    public List<Dictionary<string, object>> Talk_Dialogue;
    // Start is called before the first frame update
    void Start()
    {

        TalkPanel = gameObject;
        TalkPanel.SetActive(false);
        Transform Text = transform.Find("text/Text");
        Transform Portrait = transform.Find("portrait");
        Transform Name = transform.Find("name/Name");
        portrait_image = Portrait.GetComponent<Image>();
        talk_text = Text.GetComponent<TextMeshProUGUI>();
        name_text = Name.GetComponent<TextMeshProUGUI>();
        Talk_Dialogue = CSVReader.Read("Dialogue");
    }

    //param object sender, EventArgs e
    public void TalkStart()
    {
        CharacterMove move = player.GetComponent<CharacterMove>();
        move.enabled = false; //움직이지 않게
        TalkPanel.SetActive(true);
        ShowNextText();
    }

    void ShowNextText()
    {
        if (Talk_Dialogue[count]["event"].ToString() == "end")
        {
            TalkStop();
            return;
        }
        portrait_image.sprite = Resources.Load<Sprite>(Talk_Dialogue[count]["cg"].ToString()) as Sprite;
        StartCoroutine(Typing(Talk_Dialogue[count]["text"].ToString()));
        //talk_text.text = Talk_Dialogue[count]["text"].ToString();
        name_text.text = Talk_Dialogue[count]["name"].ToString();
        count += 1;
    }
    IEnumerator Typing(string text)
    {
        talk_text.text = "";  
        foreach (char letter in text.ToCharArray())
        {
            talk_text.text += letter;
            yield return new WaitForSeconds(0.1f);
        }
    }
    void TalkStop()
    {
        CharacterMove move = player.GetComponent<CharacterMove>();
        move.enabled = true;
        TalkPanel.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        if (gameObject.activeSelf == true && Input.GetKeyDown(KeyCode.Space))
        {
            ShowNextText();
        }
    }
}
