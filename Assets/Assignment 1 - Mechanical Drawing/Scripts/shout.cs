using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shout : MonoBehaviour
{
    public AnimationCurve bounce3;

    [Range(0, 1)]
    public float t2;
    public float pop2 = 2f;
    Vector3 original2;


    void Start()
    {
        t2 = 0;
        original2 = transform.localScale;
    }


    void Update()
    {

        t2 += Time.deltaTime;

        if (t2 > 1)
        {
            t2 = 0;
        }

        //If the player holds 's', then the jumpscare plays
        if (Input.GetKey(KeyCode.S))
        {
            transform.localScale = Vector2.one * bounce3.Evaluate(t2) * pop2;

        }

        else
        {
            transform.localScale = original2;
        }
    }
}