using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    // Transform sphere‚Æ‚¢‚¤‚Ì‚ÍTransformŒ^‚ÌSphere‚Æ‚¢‚¤–¼‘O‚Ì•Ï”‚ğì‚é
    // TransformŒ^‚ÍˆÊ’uî•ñ
    public Transform sphere;

    // Update is called once per frame
    void Update()
    {
        
        var adjustment = new Vector3(0.0f, 10.0f, 0.0f);
        //+ adjustment‚ª’Ç‰Á
        //GetComponent<Transform>().position = sphere.position;
        GetComponent<Transform>().position = sphere.position + adjustment;
    }
}
