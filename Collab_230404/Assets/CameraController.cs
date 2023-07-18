using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public GameObject target; // 카메라가 따라갈 대상
    public float moveSpeed; // 카메라가 따라갈 속도
    private Vector3 targetPosition; // 대상의 현재 위치

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // 대상이 있는지 체크
        if (target.gameObject != null)
        {
            // this는 카메라를 의미 (z값은 카메라값을 그대로 유지)
            targetPosition.Set(target.transform.position.x, target.transform.position.y, this.transform.position.z);

            // vectorA -> B까지 T의 속도로 이동
            this.transform.position = Vector3.Lerp(this.transform.position, targetPosition, moveSpeed * Time.deltaTime);
            //float lx =  10;
            //float clampX = Mathf.Clamp(transform.position.x, Debug.Log(transform.position.x); , lx );
           //Debug.Log(transform.position.x);
            //Debug.Log(transform.position.y);

            //float ly = 10;
            //float clampY = Mathf.Clamp(transform.position.y, -ly , ly);

            //this.transform.position = new Vector3(clampX, clampY, -10f); 카메라 제한 구현인데 좀 더 고민해봐야할 듯
        }
    }

 
}
