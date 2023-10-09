using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Itemtouch : MonoBehaviour
{

    public Inventory inventory;


    void Update()
    {


    }

    private void OnCollisionStay2D(Collision2D other)
    {
        Debug.Log("Hello Unity!");
        switch (other.gameObject.tag)
        {

            case "Something":
                {
                    break;
                }



        }

    }
    private void OnCollisionExit2D(Collision2D collision)
    {

    }

}