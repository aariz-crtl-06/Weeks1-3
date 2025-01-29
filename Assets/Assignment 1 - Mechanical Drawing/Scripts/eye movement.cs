using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eyemovement : MonoBehaviour
{
    //allows to add an animation curve in the inspector
    public AnimationCurve bounce2;

    //Giving info needed for the animation curve
    [Range(0, 1)]
    public float t;

    //additonal boost needed to give eyes the 'pop' effect
    public float pop = 0.3f;

    //Vector to store original eye locations
    Vector3 original;


    void Start()
    {
        //the time starts off at zero for the animation curve
        t = 0;

        //Saves original eye locations to return them later
        original = transform.localScale;
    }


    void Update()
    {
        //Tracks time passing
        t += Time.deltaTime;

        //Resets timer once it hits 1
        if (t > 1)
        {
            t = 0;
        }

        //If the player holds 's', then the eyes of the YouTuber expand
        if (Input.GetKey(KeyCode.S))
        {
            //Lets the animation curve control the scale of the eyes
            transform.localScale = Vector2.one * bounce2.Evaluate(t)*pop;

        }

        else
        {
            //when 's' isn't held down, return eyes to their original state
            transform.localScale = original;
        }
    }
}
