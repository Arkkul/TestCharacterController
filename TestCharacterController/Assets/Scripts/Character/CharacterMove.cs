using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class CharacterMove : MonoBehaviour, IControlable
{
    [SerializeField] private int _speed;
    [SerializeField] private float _jumpForce;

    private const float _accelerationOfGravity = -9.8f;
    private float _verticalMovement;

    private CharacterController _controller;

    private void Start()
    {
        _controller = GetComponent<CharacterController>();
    }

    private void Update()
    {
        GravityFall();
    }

    public void Jump()
    {
        if(_controller.isGrounded)
        {
            _verticalMovement = _jumpForce;
        }
    }

    public void Move(Vector3 _direction)
    {
        _controller.Move(_direction * _speed * Time.deltaTime);
    }

    private void GravityFall()
    {
        _controller.Move(Vector3.up * _verticalMovement * Time.deltaTime);
        _verticalMovement += _accelerationOfGravity * Time.deltaTime;
    }
}
