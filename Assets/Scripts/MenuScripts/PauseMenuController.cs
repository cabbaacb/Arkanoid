using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenuController : MonoBehaviour
{
    [SerializeField] private Button _resumeButton;
    [SerializeField] private Button _resetButton;
    [SerializeField] private Button _exitButton;



    private void Awake()
    {
        GameStateManager.Instance.OnGameStateChange += OnGameStateChanged;
        _resumeButton.onClick.AddListener(Resume);
    }

    private void OnDestroy()
    {
        GameStateManager.Instance.OnGameStateChange -= OnGameStateChanged;
        _resumeButton.onClick.RemoveAllListeners();
    }

    private void OnEnable()
    {
        GameState currentGameState = GameStateManager.Instance.CurrentGameState;
        GameState newGameState = GameState.GamePaused;
        GameStateManager.Instance.SetState(newGameState);
    }

    private void Resume()
    {

    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnGameStateChanged(GameState newGameState)
    {
        //enabled = newGameState == GameState.GamePlay;
    }
}

/*GameState currentGameState = GameStateManager.Instance.CurrentGameState;
        GameState newGameState = currentGameState == GameState.GamePlay
            ? GameState.GamePaused
            : GameState.GamePlay;*/
