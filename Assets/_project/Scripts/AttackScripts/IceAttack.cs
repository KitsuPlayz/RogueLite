using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceAttack : Enemy
{
    private Rigidbody2D rb2D;

    public void Awake()
    {
        bulletSpeed = 150f;
        rb2D = gameObject.GetComponent<Rigidbody2D>();
        rb2D.AddForce(transform.right * bulletSpeed);
        Destroy(gameObject, 7.5f);
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            Destroy(gameObject);
        }
    }
}
