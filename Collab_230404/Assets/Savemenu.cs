using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Savemenu : MonoBehaviour
{
    [SerializeField] private GameObject go_BaseUI;
    [SerializeField] private GameObject Inven_Interface;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        //go_BaseUI.SetActive(false);
        player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            menushow();
            Debug.Log("hi");
        }
        else if (Input.GetKeyDown(KeyCode.I))
        {
            Inventory_Show();
        }
    }
   private void CallMenu()
        {

            go_BaseUI.SetActive(true);
            Debug.Log("hi");
        

    }

    public void save()
    {
        PlayerPrefs.SetFloat("Lv", Timer.instance.LimitTime);
    }

     public void menushow()
    {
        if (go_BaseUI.activeSelf == true)
        {
            go_BaseUI.SetActive(false);
            player.SetActive(true);
        }
        else
        {
            go_BaseUI.SetActive(true);
            player.SetActive(false);
        }
    }
    public void Inventory_Show()
    {
        if (Inven_Interface.activeSelf == true)
        {
            Inven_Interface.SetActive(false);
            player.SetActive(true);
            Debug.Log("H");
        }
        else
        {
            Inven_Interface.SetActive(true);
            player.SetActive(false);
        }
    }
}


