using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButton : MonoBehaviour
{
    public GameObject StartPanel;
    // Start is called before the first frame update
    private void Start()
    {
        StartPanel.SetActive(false);
    }
    public void startButton()
    {
        StartPanel.SetActive(true);
    }

    // Update is called once per frame
    public void Continue()
    {
        StartPanel.SetActive(false);
    }

    public void GameExit()
    {
        Application.Quit();
    }
}
