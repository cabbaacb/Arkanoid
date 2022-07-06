using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseButton : MonoBehaviour
{
    [SerializeField] private PauseMenuController _pausePanel;
    [SerializeField] private Button _pauseButton;

    // Start is called before the first frame update
    void Start()
    {
        _pauseButton.onClick.AddListener(OpenPausePanel);
    }

   
    private void OpenPausePanel()
    {
        GameState currentState = GameStateManager.Instance.CurrentGameState;

        if (currentState == GameState.GamePaused)
        {
            _pausePanel.gameObject.SetActive(true);

        }
        else
            _pausePanel.gameObject.SetActive(false);
    }
}
