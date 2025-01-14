using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamagable : Enemy
{

    private Player player;
    private void Start()
    {
        maxEnemyHp = 5;
        enemyHp = maxEnemyHp;
        player = FindObjectOfType<Player>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("PlayerAttack"))
        {
            enemyHp = enemyHp - Player.playerAttackDamage;
            Destroy(collision.gameObject);
        }

    }

    private void Update()
    {
        if (enemyHp <= 0)
        {
            Destroy(gameObject);
        }

        Debug.Log(enemyHp);
    }
}
