using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    // Transform sphereというのはTransform型のSphereという名前の変数を作る
    // Transform型は位置情報
    public Transform sphere;

    // Update is called once per frame
    void Update()
    {
        
        var adjustment = new Vector3(0.0f, 10.0f, 0.0f);
        //+ adjustmentが追加
        //GetComponent<Transform>().position = sphere.position;
        GetComponent<Transform>().position = sphere.position + adjustment;
    }
}
