using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : Player
{
    enum Status
    {
        neutral,
        slowed,
        stunned
    }

    // Start is called before the first frame update
    void Start()
    {
        playerCurrentHealth = playerMaxHealth;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy") || collision.gameObject.CompareTag("EnemyAttack"))
        {
            playerCurrentHealth = playerCurrentHealth - Enemy.enemyAttackDamage;
            Debug.Log(playerCurrentHealth);
        }
    }
}
