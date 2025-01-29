using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shout : MonoBehaviour
{
    //allows to add an animation curve in the inspector
    public AnimationCurve bounce3;

    //Giving info needed for the animation curve
    [Range(0, 1)]
    public float t2;
    //Additional value needed for pop effect
    public float pop2 = 2f;
    //Stores original mouth location
    Vector3 original2;


    void Start()
    {
        //Timer for animation curve starts at zero
        t2 = 0;

        //Saves original mouth location to return them later
        original2 = transform.localScale;
    }


    void Update()
    {
        //Tracks time passing
        t2 += Time.deltaTime;

        //Resets timer once it hits 1
        if (t2 > 1)
        {
            t2 = 0;
        }

        //If the player holds 's', then the mouth screaming plays
        if (Input.GetKey(KeyCode.S))
        {
            //Lets the animation curve control the scale of the mouth
            transform.localScale = Vector2.one * bounce3.Evaluate(t2) * pop2;

        }

        else
        {
            //when 's' isn't held down, return mouth to their original state
            transform.localScale = original2;
        }
    }
}