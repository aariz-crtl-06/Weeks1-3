using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Roommovement : MonoBehaviour
{


    void Start()
    {
        
    }

    void Update()
        
    {
        Vector3 pos=transform.position;

        if (Input.GetKey(KeyCode.D) && pos.x>-1.4)
        {
            pos.x -= 0.03f;
            transform.position = pos;
            

        }

        if (Input.GetKey(KeyCode.A) && pos.x<1.4)
        {
            pos.x += 0.03f;
            transform.position = pos;
            

        }

    }
}
