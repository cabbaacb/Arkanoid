using UnityEngine;

public class Player1Controllers : MonoBehaviour
{
    [SerializeField, Tooltip("Player1's speed")] private float _speed;
    [SerializeField] private Rigidbody _rigidBody;
    [SerializeField] private PauseButton _pauseButton;


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

        if(_playerActions.Player.Pause.IsPressed())
            _pauseButton.OpenPausePanel();       
    }

    private void OnEnable()
    {
        _playerActions.Enable();
        BallBehaviour.OnBallRestart += GameRestart;

    }

    /*
    private void PauseGame()
    {
        _pauseButton.OpenPausePanel();
    }
    */

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

        _rigidBody.AddForce(movingHorizontal + movingVertical, ForceMode.Impulse);
    }

    private  void GameRestart(bool start)
    {
        if (start)
        {
            print("GameRestart");
            _rigidBody.velocity = Vector3.zero;
            _playerActions.Player.FreeTheBall.performed += _ => OnStartTheBall?.Invoke(true);
        }
    }
}
