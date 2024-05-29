using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private float horizontalInput;
    private float verticalInput;
    public float velocity = 5f;

    [SerializeField] private Rigidbody2D rigidbody2d;

    public void OnMovement(InputAction.CallbackContext movement)
    {
        horizontalInput = movement.ReadValue<Vector2>().x;
        verticalInput = movement.ReadValue<Vector2>().y;

    }

    public void FixedUpdate()
    {
        rigidbody2d.velocity = new Vector2(horizontalInput * velocity, verticalInput * velocity);
    }
}