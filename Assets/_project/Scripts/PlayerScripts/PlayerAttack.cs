using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.InputSystem.InputAction;

public class PlayerAttack : Player
{
    [SerializeField] GameObject playerIceAttack;
    // Start is called before the first frame update
    void Start()
    {
        playerAttackSpeed = 5;
        playerAttackDamage = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnAttack(CallbackContext _callback)
    {
        Instantiate(playerIceAttack, transform.position, transform.rotation);
        StartCoroutine("WaitToAttack");
    }

    public IEnumerator WaitToAttack()
    {
        yield return new WaitForSecondsRealtime(playerAttackSpeed);
        StartCoroutine("WaitToAttack");
    }
}
