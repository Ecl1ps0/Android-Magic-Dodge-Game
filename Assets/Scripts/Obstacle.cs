using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{ 
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Destroy(collision.gameObject);

            GameManager.instance.GameOver();
        }

        if(collision.gameObject.tag == "Ground")
        {
            GameManager.instance.incrementScore();

            Destroy(gameObject);
        }
    }
}
