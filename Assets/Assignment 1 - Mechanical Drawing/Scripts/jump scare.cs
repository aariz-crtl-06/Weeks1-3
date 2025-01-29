
//Bonnie sprite provided by PXLFLX from https://www.deviantart.com/pxlflx/art/Five-Nights-at-Freddy-s-Bonnie-Bunny-pixel-art-524648617*/*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using static UnityEditor.PlayerSettings;

public class jumpscare : MonoBehaviour
{
    //allows to add an animation curve in the inspector
    public AnimationCurve bounce;
    [Range(0,1)]
    public float t;

    void Start()
    {
        //the time starts off at zero for the animation curve
        t = 0;
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

        //If the player holds 's', then the jumpscare plays
        if (Input.GetKey(KeyCode.S))
        {
            //Lets the animation curve control the scale of the jumpscare
            transform.localScale = Vector2.one * bounce.Evaluate(t)*2.3f;

        }

        else
        {
            //when 's' isn't held down, return the jumpscare effect to a very small size
            transform.localScale = Vector2.one*0.0001f;
        }

    }
}
