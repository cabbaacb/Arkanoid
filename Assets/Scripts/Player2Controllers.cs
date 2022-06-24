using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Controllers : MonoBehaviour
{
    private Player2Actions _playerActions;
    private void Awake()
    {
        _playerActions = new Player2Actions();
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
}
