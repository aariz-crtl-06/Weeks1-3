using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour
{
   public float speed = 0.1f;

    public SpriteRenderer spriteRenderer;

    public Sprite[] sprites;

    // Start is called before the first frame update
    void Start()
    {
        //spriteRenderer.color = Random.ColorHSV();

        if (sprites.Length == 0)
        {

        }
        else { 
        spriteRenderer.sprite = sprites[Random.Range(0, sprites.Length-1)];
            spriteRenderer.sortingOrder = -1;
    }
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;
        pos.x += speed * Time.deltaTime;

        Vector2 sqaureInScreenSpace = Camera.main.WorldToScreenPoint(pos);

        if(sqaureInScreenSpace.x < -10 || sqaureInScreenSpace.x > Screen.width)
        {
            speed = speed * -1;
        }

        transform.position = pos;


    }
}
