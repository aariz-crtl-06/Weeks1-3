using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class bouncingShape : MonoBehaviour
{

    public float speed = 0.5f;
    public float t;
    float jeeter = 5;
    public AnimationCurve jump;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;
        pos.x += speed * Time.deltaTime;

        Vector2 sqaureInScreenSpace = Camera.main.WorldToScreenPoint(pos);

        if (sqaureInScreenSpace.x < -10 || sqaureInScreenSpace.x > Screen.width)
        {
            speed = speed * -1;
        }

        t += Time.deltaTime;

        if (t > 1)
        {
            t = 0;
        }


        transform.position = pos;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //transform.position = Vector2.one * jump.Evaluate(t);
            t *= 5;
            Debug.Log("TEST: ");
        }

        if(Input.GetKeyUp(KeyCode.Space))
        {
            //transform.position = Vector2.one * jump.Evaluate(t);
            t *= -5;
        }
    }
}
