using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerIceAttack : Player
{
    private Rigidbody2D rb2D;
    public void Awake()
    {
        playerBulletSpeed = 5f;
        rb2D = gameObject.GetComponent<Rigidbody2D>();
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 moveDir = mousePos - transform.position;
        moveDir.z = 0.0f;
        Vector3 moveDirNormalized = moveDir.normalized;
        rb2D.velocity = moveDirNormalized * playerBulletSpeed;
        Destroy(gameObject, 7.5f);
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            collision.gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            Destroy(gameObject);
        }
    }
}
