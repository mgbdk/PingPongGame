using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RacketAI : Racket
{
    public Transform ball;
    public float referenceVal;
    protected override void FixedUpdate()
    {
        float topRacketDistanceY = Math.Abs(ball.position.y - transform.position.y);
        Debug.Log(topRacketDistanceY);
        if(topRacketDistanceY > referenceVal)
        {
            if (ball.position.y > transform.position.y)
                rb2.velocity = Vector2.up * moveSpeed;
  
            else
                rb2.velocity = Vector2.down * moveSpeed;
        }
        
    }
}
