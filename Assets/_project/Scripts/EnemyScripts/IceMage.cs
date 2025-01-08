using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceMage : Enemy
{
    private bool playerInRange = false;

    public void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            playerInRange = true;
            Debug.Log(playerInRange);
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            playerInRange = false;
            Debug.Log(playerInRange);
        }
    }


    public void UseAttack(GameObject IceAttack)
    {
        enemyAttackRange = 5;

        if (playerInRange)
        {
            
        }
    }
}
