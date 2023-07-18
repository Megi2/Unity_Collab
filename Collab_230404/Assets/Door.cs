using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Door : MonoBehaviour
{
  

   

private void OnCollisionStay2D(Collision2D other)
    {
        Debug.Log("Hello Unity!");
        switch (other.gameObject.tag)//스위치문 이용
        {
            
            case "Door1": {
             float time1 = Timer.instance.LimitTime;
                    if (time1> 30){//특정 시간 넘어가야 문 열림
                        transform.position = new Vector2(25, 0);
                        
                    }
                    break;
                }

            case "Door2":
                {
                    transform.position = new Vector2(3, 0);
                    break;
                }


        }

        }
    private void OnCollisionExit2D(Collision2D collision)
    {
        
    }
    
}

