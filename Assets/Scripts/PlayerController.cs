using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //��b�ԂɈ��̉񐔌Ă΂��
    void FixedUpdate()
    {
        // ���͂�x��z�ɑ��
        float x = Input.GetAxis("Horizontal"); // ���������A���L�[���E�̓��͂�-1����1�܂ł̏����ŕԂ��B
        float z = Input.GetAxis("Vertical");  // ���������A���L�[�̏㉺�ɑΉ��B

        // Rigidbody���擾
        Rigidbody rb = GetComponent<Rigidbody>();
        // �ʂɗ͂�������
        rb.AddForce(x * 10, 0, z * 10);
    }
}
