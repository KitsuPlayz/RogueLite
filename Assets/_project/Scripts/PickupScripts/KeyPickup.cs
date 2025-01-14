using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPickup : Player
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            amountOfKeys++;
            Destroy(gameObject);
        }
    }
}
