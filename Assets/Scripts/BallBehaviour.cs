using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehaviour : MonoBehaviour
{
    [SerializeField, Range(1, 25), Tooltip("Ball Speed")] private float _speed = 1f;
    [SerializeField] private PlayerController _player1;
   
    [SerializeField, Tooltip("Direction Vector")] private Vector3 _movingDirection;

    private float _minVelocity = 1;
    private float _maxVelocity = 25;

    public delegate void BallRestartHandler(bool start);
    public static event BallRestartHandler OnBallRestart;
      

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
        Moving(_movingDirection);
    }

    private void Restart()
    {
        StartCoroutine(SpeedIncreasing());
        _movingDirection = Vector3.zero;
        _speed = _minVelocity;
        transform.Translate(Vector3.zero);
        transform.position = new Vector3(_player1.transform.position.x, 9.5f, _player1.transform.position.z);
    }

    private void StartMoving(bool start)
    {
        OnBallRestart?.Invoke(false);

        _movingDirection = new Vector3(0, -1, 0) * _speed;       
        
    }

    private IEnumerator SpeedIncreasing()
    {
        if (_speed != _maxVelocity)
            _speed += 0.5f;
        yield return new WaitForSeconds(5f);
        StartCoroutine(SpeedIncreasing());
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


        _movingDirection = Reflection(collision.contacts[0].normal);

    }


    private Vector3 Reflection(Vector3 collisionNormal)
    {

        var direction = Vector3.Reflect(_movingDirection.normalized, collisionNormal.normalized);

        return direction * Mathf.Max(_speed, _minVelocity);

    }

    private void Moving(Vector3 direction)
    {
        transform.Translate(direction * Time.deltaTime);
    }

   

}
