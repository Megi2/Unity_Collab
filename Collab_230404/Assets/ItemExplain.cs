using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;


public class ItemExplain : MonoBehaviour, IPointerClickHandler
{

    public int index;
    public TMP_Text ItemExplains;
    public Inventory inventory;
   [SerializeField] private GameObject go_BaseUI;
    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Left)
        {

            Debug.Log("on");
            ItemExplains.text=inventory.getItemExplain(index).itemName;
            // image = inventory.getItemExplain(index).itemName;
            go_BaseUI.SetActive(true);



        }
        else if (eventData.button == PointerEventData.InputButton.Middle)
        {
            Debug.Log("Mouse Click Button : Middle");
        }
        else if (eventData.button == PointerEventData.InputButton.Right)
        {
            Debug.Log("Mouse Click Button : Right");
        }

        Debug.Log("Mouse Position : " + eventData.position);
        Debug.Log("Mouse Click Count : " + eventData.clickCount);
    }


    public void ExitExplain()
    {

        go_BaseUI.SetActive(false);
 


    }
}