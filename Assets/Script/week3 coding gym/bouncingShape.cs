using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class bouncingShape : MonoBehaviour
{

    public float speed = 0.5f;
    public float t;
    public float t2;
    [Range(0,1)]
    public bool isPressed = false;
    public AnimationCurve jump;
    public AnimationCurve spin;

    // Start is called before the first frame update
    void Start()
    {
        t = 0;
        t2 = 0;
    }

    // Update is called once per frame
    void Update()
    {
        bounce();
    }
void bounce()
    {

        Vector3  pos = transform.position;
        Vector3 rot = transform.eulerAngles;
        pos.x += speed * Time.deltaTime;

        Vector3 shapeInScreenSpace = Camera.main.WorldToScreenPoint(pos);

        if (shapeInScreenSpace.x < -10 || shapeInScreenSpace.x > Screen.width)
        {
            speed = speed * -1;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            isPressed = true;
        }

        if (isPressed)
        {
            t += Time.deltaTime;
            t2 += Time.deltaTime;
            if (t > 1f)
            {
                t = 0;
                isPressed = false;
            }

            if (t2> 1f)
            {
                t2= 0;
              
            }
        }


        pos.y = jump.Evaluate(t);
        rot.z = spin.Evaluate(t2);
        transform.position = pos;
        transform.eulerAngles = rot;
   

    }


}
