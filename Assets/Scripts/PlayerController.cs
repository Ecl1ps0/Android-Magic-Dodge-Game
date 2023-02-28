using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    
    Rigidbody2D rb;
    SpriteRenderer sr;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    void FixedUpdate()
    {
        if (Input.GetMouseButton(0))
        {
            if(Input.mousePosition.x < Screen.width / 2)
            {
                rb.velocity = Vector2.left * moveSpeed;

                sr.flipX = true;
            } 
            else
            {
                rb.velocity = Vector2.right * moveSpeed;

                sr.flipX = false;
            }
        }
    }
}
