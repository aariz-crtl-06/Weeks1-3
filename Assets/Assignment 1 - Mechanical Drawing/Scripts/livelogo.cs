using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class livelogo : MonoBehaviour
{
    [Range(0,1)]
    public float t;
    public AnimationCurve curve;

    public Vector2 start;
    public Vector2 end; 

    // Start is called before the first frame update
    void Start()
    {
        t = 0; 
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;

        if (t > 1)
        {
            t = 0;
        }

        transform.position = Vector2.Lerp(start, end, curve.Evaluate(t));

    }
}
