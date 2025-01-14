using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceMage : Enemy
{
    [SerializeField] GameObject iceAttack; 
    private bool playerInRange = false;

    private void Start()
    {
        enemyAttackSpeed = 2;
       
    }
    private void Update()
    {
        
    }
    //checks if the player is in range of the Ice Mage for it to attack.
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            StartCoroutine("WaitToAttack");
            playerInRange = true;
        }
           
    }
    
    //checks if the player left the range.
    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            playerInRange = false;
            Debug.Log(playerInRange);
        }
    }

    //instantiates the attack when the player is in range.
    public void UseAttack()
    {
        enemyAttackRange = 5;
        Instantiate(iceAttack, transform.position, transform.rotation);
        
    }

    public IEnumerator WaitToAttack()
    {
        UseAttack();
        yield return new WaitForSecondsRealtime(enemyAttackSpeed);
        if (playerInRange)
        {
            StartCoroutine("WaitToAttack");
        }
    }
}
