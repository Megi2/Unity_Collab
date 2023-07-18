using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public GameObject target; // ī�޶� ���� ���
    public float moveSpeed; // ī�޶� ���� �ӵ�
    private Vector3 targetPosition; // ����� ���� ��ġ

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // ����� �ִ��� üũ
        if (target.gameObject != null)
        {
            // this�� ī�޶� �ǹ� (z���� ī�޶��� �״�� ����)
            targetPosition.Set(target.transform.position.x, target.transform.position.y, this.transform.position.z);

            // vectorA -> B���� T�� �ӵ��� �̵�
            this.transform.position = Vector3.Lerp(this.transform.position, targetPosition, moveSpeed * Time.deltaTime);
            //float lx =  10;
            //float clampX = Mathf.Clamp(transform.position.x, Debug.Log(transform.position.x); , lx );
           //Debug.Log(transform.position.x);
            //Debug.Log(transform.position.y);

            //float ly = 10;
            //float clampY = Mathf.Clamp(transform.position.y, -ly , ly);

            //this.transform.position = new Vector3(clampX, clampY, -10f); ī�޶� ���� �����ε� �� �� ����غ����� ��
        }
    }

 
}
