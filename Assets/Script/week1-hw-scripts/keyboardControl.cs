using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyboardControl : MonoBehaviour
{
    public float speed = 5;
    public float rotationSpeed = 200;

   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Vector2 pos = transform.position;

        //pos.x += Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        //pos.y += Input.GetAxis("Vertical") * speed * Time.deltaTime;

        //transform.position = pos;

        transform.Rotate(0, 0, -Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime);
        transform.Translate(0,Input.GetAxis("Vertical") * speed * Time.deltaTime, 0);
    }
}
