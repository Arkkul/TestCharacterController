using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    private Input _input;
    private IControlable _controlable;

    private void Awake()
    {
        _input = new Input();
        _input.Enable();
        _controlable = GetComponent<IControlable>();

        _input.Player.Jump.performed += Jump_performed;
    }

    private void Update()
    {
        ReadMovement();
    }

    private void Jump_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        _controlable.Jump();
        Debug.Log("jumpPerformed");
    }

    private void ReadMovement()
    {
        Vector2 _inputDirection = _input.Player.Move.ReadValue<Vector2>();
        Vector3 _direction = new Vector3 (_inputDirection.x, 0, _inputDirection.y);

        _controlable.Move(_direction);
    }

    private void OnEnable()
    {
        _input.Enable();
    }

    private void OnDisable()
    {
        _input.Disable();
    }
}
