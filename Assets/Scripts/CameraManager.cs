using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    // Transform sphere�Ƃ����̂�Transform�^��Sphere�Ƃ������O�̕ϐ������
    // Transform�^�͈ʒu���
    public Transform sphere;

    // Update is called once per frame
    void Update()
    {
        
        var adjustment = new Vector3(0.0f, 10.0f, 0.0f);
        //+ adjustment���ǉ�
        //GetComponent<Transform>().position = sphere.position;
        GetComponent<Transform>().position = sphere.position + adjustment;
    }
}
