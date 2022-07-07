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

    [SerializeField] private PauseButton _pauseButton;


    private void Awake()
    {
        //GameStateManager.Instance.OnGameStateChange += OnGameStateChanged;

        _resumeButton.onClick.AddListener(Resume);
        _exitButton.onClick.AddListener(OpenMainMenu);
        _resetButton.onClick.AddListener(RestartGame);
    }

    private void OnDestroy()
    {
        //GameStateManager.Instance.OnGameStateChange -= OnGameStateChanged;

        _resumeButton.onClick.RemoveAllListeners();
        _exitButton.onClick.RemoveAllListeners();
        _resetButton.onClick.RemoveAllListeners();
    }

    private void OnEnable()
    {
        /*
        GameState currentGameState = GameStateManager.Instance.CurrentGameState;
        GameState newGameState = GameState.GamePaused;
        GameStateManager.Instance.SetState(newGameState);*/
    }

    private void Resume()
    {
        _pauseButton.IsRunning = false;
        _pauseButton.OpenPausePanel();
    }


    private void OpenMainMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    private void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}


