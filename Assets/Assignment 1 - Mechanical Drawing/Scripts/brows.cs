using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class brows : MonoBehaviour
{
    

    public float move;
     

    void Start()
    {
       
    }


    void Update()
    {
        move = 3;
        Vector3 pos = transform.position;


        if (Input.GetKey(KeyCode.S))
        {
            pos.y = 2.8f;
            
        }

        else
        {
            pos.y = 2.7328f;
        }
        transform.position = pos;
    }
}