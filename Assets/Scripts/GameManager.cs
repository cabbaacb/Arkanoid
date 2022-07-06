using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    [SerializeField] private GameObject _ball;
    [SerializeField] private GameObject _player1;
    [SerializeField] private GameObject _player2;


    private void OnEnable()
    {
        GameStateManager.Instance.OnGameStateChange += OnGameStateChanged;
    }

    private void OnDisable()
    {
        GameStateManager.Instance.OnGameStateChange -= OnGameStateChanged;
    }
    // Start is called before the first frame update
    void Start()
    {
        _ball = FindObjectOfType<BallBehaviour>().GetComponent<GameObject>();
        _player1 = FindObjectOfType<Player1Controllers>().GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnGameStateChanged(GameState newGameState)
    {
        if (newGameState == GameState.GamePaused)
        {
            _ball.SetActive(false);
            _player1.SetActive(false);
        }
        else
        {
            _ball.SetActive(true);
            _player1.SetActive(true);
        }
    }
}
