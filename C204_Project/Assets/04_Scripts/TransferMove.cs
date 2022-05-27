using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransferMove : MonoBehaviour
{
    //public : 유니티 엔진에서도 사용이가능
    //private : 해당 스크립트 내에서만 사용이 가능
    public float speed = 20.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //키보드 입력
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        //이동거리 보정
        h = h * speed * Time.deltaTime;
        v = v * speed * Time.deltaTime;

        // 실제 이동
        transform.Translate(Vector3.right * h);
        transform.Translate(Vector3.forward * v);
    }
}
