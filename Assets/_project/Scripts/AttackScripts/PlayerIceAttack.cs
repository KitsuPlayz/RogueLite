using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerIceAttack : Player
{
    private Rigidbody2D rb2D;

    public void Awake()
    {
        playerBulletSpeed = 150f;
        rb2D = gameObject.GetComponent<Rigidbody2D>();
        rb2D.AddForce(transform.right * playerBulletSpeed);
        Destroy(gameObject, 7.5f);
    }
}
