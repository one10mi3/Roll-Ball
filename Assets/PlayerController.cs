using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //一秒間に一定の回数呼ばれる
    void FixedUpdate()
    {
        // 入力をxとzに代入
        float x = Input.GetAxis("Horizontal"); // 水平方向、矢印キー左右の入力を-1から1までの小数で返す。
        float z = Input.GetAxis("Vertical");  // 垂直方向、矢印キーの上下に対応。

        // Rigidbodyを取得
        Rigidbody rb = GetComponent<Rigidbody>();
        // 玉に力を加える
        rb.AddForce(x * 10, 0, z * 10);
    }
}
