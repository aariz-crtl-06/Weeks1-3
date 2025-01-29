using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class brows : MonoBehaviour
{
    
    //Gives a variable for how much brows should move
    public float move;
     

    void Start()
    {
       
    }


    void Update()
    {
        //Eyerbows should move by 3
        move = 3;

        //Creates vector that effects eyebrow position
        Vector3 pos = transform.position;

        //If 's' is held down then the y value for eyebrow changes
        if (Input.GetKey(KeyCode.S))
        {
            pos.y = 2.8f;
            
        }

        //If 's' isn't held, keeps eyebrow at it's regular y value
        else
        {
            pos.y = 2.7328f;
        }
        //Transforms the position of the eyebrow
        transform.position = pos;
    }
}