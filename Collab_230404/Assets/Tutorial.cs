using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject E;
    public void showE()
    {
        E.SetActive(true);
    }
    public void hideE()
    {
        E.SetActive(false);
    }
    void Start()
    {
        // E = GameObject.Find("E");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
