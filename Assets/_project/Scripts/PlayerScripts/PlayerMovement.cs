using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.InputSystem.InputAction;

public class PlayerMovement : Player
{
    [SerializeField] SpriteRenderer p_Sprite;
    float inputHorizontal;

    private Vector2 movementVectors;

    private void Start()
    {
        playerMovementSpeed = 0.1f;
    }

    public void PlayerMoving(CallbackContext _callback)
    {
        movementVectors = _callback.ReadValue<Vector2>();
    }

    public void FixedUpdate()
    {
        inputHorizontal = Input.GetAxisRaw("Horizontal");
        if (inputHorizontal < 0)
        {
            p_Sprite.flipX = true;
        }
        else if (inputHorizontal > 0)
        {
            p_Sprite.flipX = false;
        }
        transform.Translate(movementVectors.normalized * playerMovementSpeed);
    }
}
