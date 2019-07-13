using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    Rigidbody2D rb2;
    public float moveSpeed;
    public Racket solRaket, sagRaket;
    AudioSource audioSource;
    void Start()
    {
        rb2 = GetComponent<Rigidbody2D>();
        rb2.velocity = new Vector2(1, 0) * moveSpeed;
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        audioSource.Play();
        if (collision.gameObject.GetComponent<TagManager>() == null) return;
        Tags tags = collision.gameObject.GetComponent<TagManager>().tags;
        if(tags == Tags.SOL_KALE)
        {
            sagRaket.makeScore();
        }
        if(tags == Tags.SAG_KALE)
        {
            solRaket.makeScore();
        }
        if(tags == Tags.SOL_RAKET)
        {
            SetReturnVelocity(1, collision);
        }
        //if (tags == Tags.SAG_RAKET)
        //{
        //    SetReturnVelocity(1, collision);
        //}
    }

    private void SetReturnVelocity(int x, Collision2D collision)
    {
        float a = transform.position.y - collision.collider.bounds.center.y;
        float b = collision.collider.bounds.size.y / 2;
        float y = a / b;
        rb2.velocity = new Vector2(x, y) * moveSpeed;
    }
}
