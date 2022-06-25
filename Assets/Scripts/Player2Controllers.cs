using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Controllers : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Rigidbody _rigidBody;

    private Player2Actions _playerActions;
    private void Awake()
    {
        _rigidBody = GetComponent<Rigidbody>();
        _playerActions = new Player2Actions();
    }

    private void FixedUpdate()
    {
        Moving();
    }

    private void OnEnable()
    {
        _playerActions.Enable();
    }

    private void OnDisable()
    {
        _playerActions.Disable();
    }

    private void OnDestroy()
    {
        _playerActions.Dispose();
    }

    private void Moving()
    {
        float horizontalInput = _playerActions.Player.MovingHorizontal.ReadValue<float>();
        float verticalInput = _playerActions.Player.MovingVertical.ReadValue<float>();

        Vector3 movingHorizontal = transform.forward * _speed * horizontalInput * Time.fixedDeltaTime;
        Vector3 movingVertical = transform.right * _speed * verticalInput * Time.fixedDeltaTime;

        //_rigidBody.MovePosition(_rigidBody.position + movingHorizontal + movingVertical);
        _rigidBody.AddForce(movingHorizontal + movingVertical, ForceMode.Impulse);
    }
}


