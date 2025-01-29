using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eyemovement : MonoBehaviour
{
    public AnimationCurve bounce2;

    [Range(0, 1)]
    public float t;
    public float pop = 0.3f;
    Vector3 original;


    void Start()
    {
        t = 0;
        original = transform.localScale;
    }


    void Update()
    {

        t += Time.deltaTime;

        if (t > 1)
        {
            t = 0;
        }

        //If the player holds 's', then the jumpscare plays
        if (Input.GetKey(KeyCode.S))
        {
            transform.localScale = Vector2.one * bounce2.Evaluate(t)*pop;

        }

        else
        {
            transform.localScale = original;
        }
    }
}
