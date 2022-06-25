using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehaviour : MonoBehaviour
{
    [SerializeField, Range(10, 100)] private float _speed = 15;
    [SerializeField] private PlayerController _player1;
    [SerializeField] private Rigidbody _rigidbody;

    private float _minVelocity = 10;

    public delegate void BallRestartHandler(bool start);
    public static event BallRestartHandler OnBallRestart;

    private Vector3 _lastFrameVelocity;
    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        Restart();
        OnBallRestart?.Invoke(true);
    }        

    private void OnEnable()
    {
        
        Player1Controllers.OnStartTheBall += StartMoving;
    }

    private void OnDisable()
    {
        Player1Controllers.OnStartTheBall -= StartMoving;
    }

    // Update is called once per frame
    void Update()
    {
        _lastFrameVelocity = _rigidbody.velocity;
    }

    private void Restart()
    {
        _rigidbody.velocity = Vector3.zero;
        transform.position = new Vector3(_player1.transform.position.x, 10f, _player1.transform.position.z);
    }

    private void StartMoving(bool start)
    {
        OnBallRestart?.Invoke(false);
        _rigidbody.AddForce(new Vector3(0, -1, 0) * _speed, ForceMode.Acceleration);
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if ((collision.gameObject.name == "Gates1") || (collision.gameObject.name == "Gates2"))
        {
            Restart();
            OnBallRestart?.Invoke(true);
            _player1.SetDamage(1);
            return;
        }

        else if ((collision.gameObject.name != "Player1") && (collision.gameObject.name != "Player2")
            && (collision.gameObject.name != "Wall1") && (collision.gameObject.name != "Wall2")
            && (collision.gameObject.name != "Wall3") && (collision.gameObject.name != "Wall4"))
        {
            Destroy(collision.gameObject);
        }


        Reflection(collision.contacts[0].normal);

    }


    private void Reflection(Vector3 collisionNormal)
    {
        var speed = _lastFrameVelocity.magnitude;
        var direction = Vector3.Reflect(_lastFrameVelocity.normalized, collisionNormal.normalized);
        _rigidbody.velocity = direction * Mathf.Max(_speed, _minVelocity) * 0.5f;
    }


}
