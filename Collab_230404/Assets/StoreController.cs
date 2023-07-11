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
     //날짜와 문서를 받아와서 오늘 방문할 손님 결정
     //손님 별 struct 만들기
     //캐릭터 비활성화
     //ui 띄우기
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
