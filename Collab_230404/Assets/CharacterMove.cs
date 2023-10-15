using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed;
    Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxisRaw("Horizontal");
        float inputY = Input.GetAxisRaw("Vertical");
        if (inputX != 0 || inputY != 0)
            anim.SetBool("IsMove", true);
        else
            anim.SetBool("IsMove", false);

        anim.SetFloat("InputX", inputX);
        anim.SetFloat("InputY", inputY);

        transform.Translate(new Vector2(inputX, inputY) * Time.deltaTime * moveSpeed);
    }
}
