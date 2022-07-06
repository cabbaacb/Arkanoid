using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateManager : MonoBehaviour
{
    private static GameStateManager _instance;

    public delegate void GameStateChangeHandler(GameState newGameState);
    public event GameStateChangeHandler OnGameStateChange;

    public static GameStateManager Instance
    {
        get
        {
            if (_instance == null)
                _instance = new GameStateManager();

            return _instance;
        }
    }

  
    public GameState CurrentGameState
    {
        get;
        private set;
    }

    public void SetState(GameState newGameState)
    {
        if (newGameState == CurrentGameState) return;

        CurrentGameState = newGameState;
        OnGameStateChange?.Invoke(newGameState);
    }

   
}
public enum GameState
{
    GamePlay,
    GamePaused
}