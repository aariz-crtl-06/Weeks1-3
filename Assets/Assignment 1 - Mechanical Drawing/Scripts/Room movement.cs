
//Office Pixel art provided by ArtstotzkanPlagueDoc from https://www.deviantart.com/arstotzkanplaguedoc/art/FNAF-1-office-pixel-art-864769350 


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Roommovement : MonoBehaviour
{


    void Start()
    {
        
    }

    void Update()
        
    {
        //Variable stores current x y z positions
        Vector3 pos=transform.position;

        //if 's' is being pressed down while the screen hasn't moved too far off the screen, let the image pan to the left side of the room.
        if (Input.GetKey(KeyCode.D) && pos.x>-1.4)
        {
            pos.x -= 0.03f;
            transform.position = pos;
            

        }
        //if 's' is being pressed down while the screen hasn't moved too far off the screen, let the image pan to the right side of the room.
        if (Input.GetKey(KeyCode.A) && pos.x<1.4)
        {
            pos.x += 0.03f;
            transform.position = pos;
            

        }

    }
}
