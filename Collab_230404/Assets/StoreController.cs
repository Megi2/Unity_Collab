using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public struct customer
{
    public string name;
    public string issue;
    public string goods;

}
public class StoreController : MonoBehaviour
{
    public int personnel = 0;



    // Start is called before the first frame update
    void Start()
    {
     //��¥�� ������ �޾ƿͼ� ���� �湮�� �մ� ����
     //�մ� �� struct �����
     //ĳ���� ��Ȱ��ȭ
     //ui ����
    }

    void visit()
    {
        personnel--;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
