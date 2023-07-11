using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorController : MonoBehaviour
{
    GameObject nameTag;
    string sceneName;
    // Start is called before the first frame update
    void Start()
    {
        nameTag = GameObject.Find("store");
        nameTag.SetActive(false);
        sceneName = nameTag.name;

    }

    // Update is called once per frame
    void OnCollisionStay2D(Collision2D collision)
    {
        nameTag.gameObject.SetActive(true);
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("이세카이 전송");
            SceneManager.LoadScene(sceneName);
        }
    }
}
