using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class PlayerData
{
    //데이터들
    public string name;
    public string data1;
    public int data2;
    public int data3;

}


public class DataManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static DataManager instance;

    public PlayerData nowPlayer = new PlayerData();
    public string path;
    //string filename = "save";
    public int nowSlot;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(instance.gameObject);

        }
        DontDestroyOnLoad(this.gameObject);

        path = Application.persistentDataPath + "/save";

    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SaveData()
    {
        string data = JsonUtility.ToJson(nowPlayer);
        File.WriteAllText(path + nowSlot.ToString(),  data);
        print(path);
    }

    public void LoadData()
    {
        string data = File.ReadAllText(path + nowSlot.ToString());
        nowPlayer = JsonUtility.FromJson<PlayerData>(data);
    }

    public void DataClear()
    {
        nowSlot = -1;
        nowPlayer = new PlayerData();
    }
}
