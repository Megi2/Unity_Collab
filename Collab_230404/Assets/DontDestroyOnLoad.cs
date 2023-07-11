using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyOnLoad : MonoBehaviour
{
    // Start is called before the first frame update
    private static DontDestroyOnLoad s_Instance = null;
    void Awake()
    {
        if (s_Instance)
        {
            DontDestroyOnLoad(this.gameObject);
            return;
        }
        s_Instance = this;
        DontDestroyOnLoad(this.gameObject);
    }

}
