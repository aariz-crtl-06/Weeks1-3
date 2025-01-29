
//Live logo sprite provided by FreeP!K from https://www.freepik.com/premium-vector/cute-live-streaming-icon-with-cat-pixel-art-style_355335818.htm

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class livelogo : MonoBehaviour
{
    //Giving info needed for the animation curve
    [Range(0,1)]
    public float t;
    //allows to add an animation curve in the inspector
    public AnimationCurve curve;

    //Gives locations for starting and ending points that can be modified in inspector
    public Vector2 start;
    public Vector2 end; 

    
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
        //Let's the logo move between set start and end values, using the animation curve
        transform.position = Vector2.Lerp(start, end, curve.Evaluate(t));

    }
}
