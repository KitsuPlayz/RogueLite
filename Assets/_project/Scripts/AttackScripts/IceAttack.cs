using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceAttack : Enemy
{
    private Rigidbody2D rb2D;
    private GameObject target;
    public void Awake()
    {
        bulletSpeed = 10f;
        rb2D = gameObject.GetComponent<Rigidbody2D>();
        target = GameObject.FindGameObjectWithTag("Player");
        Vector2 moveDir = (target.transform.position - transform.position).normalized * bulletSpeed;
        rb2D.velocity = new Vector2(moveDir.x, moveDir.y);
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
