using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Racket : MonoBehaviour
{
    protected Rigidbody2D rb2;
    public float moveSpeed;
    int score;
    public Text racketScore;
    public string axisName;
    protected void Start()
    {
        rb2 = GetComponent<Rigidbody2D>();
    }

    protected virtual void FixedUpdate()
    {
        float moveAxis = Input.GetAxis(axisName);
        rb2.velocity = new Vector2(0, moveAxis) * moveSpeed;
    }

    public void makeScore()
    {
        score++;
        racketScore.text = score.ToString();

    }
}
