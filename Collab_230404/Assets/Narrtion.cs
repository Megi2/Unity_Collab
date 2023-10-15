using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Narrtion : MonoBehaviour
{
    public TextMeshProUGUI talk_text;
    public string[] narrtion_text = new string[3];
    public GameObject controller;

    public int count;
    InputEvent ie;
    // Start is called before the first frame update
    void Start()
    {
        ie = gameObject.GetComponent<InputEvent>();
        count = 0;
        narrtion_text[0] = "Wake up...";
        narrtion_text[1] = "It's time to wake up";
        narrtion_text[2] = "...Bern";
        Transform Text = transform.GetChild(0);
        talk_text = Text.GetComponent<TextMeshProUGUI>();
        StartCoroutine(Typing(narrtion_text[count]));
    }

    IEnumerator Typing(string text)
    {
        talk_text.text = "";
        
        foreach (char letter in text.ToCharArray())
        {
            int index = 0;
            if (index > 3 && Input.GetKeyDown(KeyCode.Space))
            {
               
                talk_text.text = narrtion_text[count];
                Debug.Log("early stop");
                break;
            }
            index++; 
            talk_text.text += letter;
            yield return new WaitForSeconds(0.1f);
        }
        
    }
    public void ShowNextText()
    {
        ie.enabled = false;
        count++;
        if (count == 3){
            controller.GetComponent<NPCTalk>().TalkStart();
            gameObject.SetActive(false);

        }
        else
        {
            StartCoroutine(Typing(narrtion_text[count]));
        }
        ie.enabled = true;
    }
    // Update is called once per frame
    void Update()
    {
    }
}
