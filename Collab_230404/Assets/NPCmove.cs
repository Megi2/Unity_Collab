using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCmove : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed;
    int i=1;
    int j = 1;
    Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {


        if (i % 400==0)
        {
            i++;
            j = j*(-1);
           
        }
        else if(i==400000)
        {
            i = 1;
            j = j * (-1); //overflow¹æÁö
        }
        else
        {
            if (j == 1)
            {
                anim.SetBool("left", true);
                anim.SetBool("right", false);
                transform.Translate(new Vector2(-1, 0) * Time.deltaTime * moveSpeed);
                i++;
            }
            else
            {
                anim.SetBool("right", true);
                anim.SetBool("left", false);
                transform.Translate(new Vector2(1, 0) * Time.deltaTime * moveSpeed);
                i++;
            }
        }



    }
}