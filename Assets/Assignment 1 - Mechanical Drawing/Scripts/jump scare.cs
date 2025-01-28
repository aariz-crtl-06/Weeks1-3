using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using static UnityEditor.PlayerSettings;

public class jumpscare : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
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
