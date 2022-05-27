using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransferMove : MonoBehaviour
{
    //public : ����Ƽ ���������� ����̰���
    //private : �ش� ��ũ��Ʈ �������� ����� ����
    public float speed = 20.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Ű���� �Է�
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        //�̵��Ÿ� ����
        h = h * speed * Time.deltaTime;
        v = v * speed * Time.deltaTime;

        // ���� �̵�
        transform.Translate(Vector3.right * h);
        transform.Translate(Vector3.forward * v);
    }
}
