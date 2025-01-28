using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using static UnityEditor.PlayerSettings;

public class jumpscare : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetKey(KeyCode.S))
        {
            transform.localScale = Vector2.one * 2.3f;
        }

        else
        {
            transform.localScale = Vector2.one*0.0001f;
        }

    }
}
