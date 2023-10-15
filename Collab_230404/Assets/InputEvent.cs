using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputEvent : MonoBehaviour
{
    Narrtion narr;
    // Start is called before the first frame update
    void Start()
    {
        narr = gameObject.GetComponent<Narrtion>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.activeSelf == true && Input.GetKeyDown(KeyCode.Space))
        {
            narr.ShowNextText();
        }
    }
}
