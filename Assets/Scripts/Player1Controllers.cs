using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class Player1Controllers : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Rigidbody _rigidBody;

    private Player1Actions _playerActions;

    public delegate void StartTheBallHandler(bool start);
    public static event StartTheBallHandler OnStartTheBall;

    private void Awake()
    {

        _rigidBody = GetComponent<Rigidbody>();
        _playerActions = new Player1Actions();
    }

    private void FixedUpdate()
    {
        Moving();
    }

    private void OnEnable()
    {
        _playerActions.Enable();
        BallBehaviour.OnBallRestart += GameRestart;


    }

    private void OnDisable()
    {
        _playerActions.Disable();
        BallBehaviour.OnBallRestart -= GameRestart;
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

    private  void GameRestart(bool start)
    {
        if (start)
        {
            print("GameRestart");
            _playerActions.Player.FreeTheBall.performed += _ => OnStartTheBall?.Invoke(true);
        }
        //await Task.Yield();
    }
}
