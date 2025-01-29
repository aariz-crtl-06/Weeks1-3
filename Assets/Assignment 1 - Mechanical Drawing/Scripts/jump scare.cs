using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using static UnityEditor.PlayerSettings;

public class jumpscare : MonoBehaviour
{

    public AnimationCurve bounce;
    [Range(0,1)]
    public float t;

    void Start()
    {
        t = 0;
    }

    
    void Update()
    {

        t+= Time.deltaTime;

        if (t > 1)
        {
            t = 0;
        }


        if (Input.GetKey(KeyCode.S))
        {
            transform.localScale = Vector2.one * bounce.Evaluate(t)*2.3f;

        }

        else
        {
            transform.localScale = Vector2.one*0.0001f;
        }

    }
}
