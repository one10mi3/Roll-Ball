using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider hit)
    {
        //当たった時の処理を記述
        if (hit.CompareTag("Player"))
        {
            //処理を記述
            Destroy(gameObject);
        }
    }
}
