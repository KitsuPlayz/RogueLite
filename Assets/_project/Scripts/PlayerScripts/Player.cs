using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] int playerMaxHealth;
    [SerializeField] int playerCurrentHealth;
    [SerializeField] float playerMovementSpeed;
    [SerializeField] float playerAttackSpeed;
    [SerializeField] float playerAttackDamage;
    [SerializeField] float playerAttackRange;
}
