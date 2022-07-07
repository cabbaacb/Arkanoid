using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseButton : MonoBehaviour
{
    [SerializeField] private PauseMenuController _pausePanel;
    [SerializeField] private Button _pauseButton;

    

    private bool isRunning = true;

    public bool IsRunning { get => isRunning; set => isRunning = value; }

    // Start is called before the first frame update
    void Start()
    {
        _pauseButton.onClick.AddListener(OpenPausePanel);
    }

    private void OnDisable()
    {
        _pauseButton.onClick.RemoveAllListeners();
    }
    public void OpenPausePanel()
    {
        if(isRunning)
        {
            Time.timeScale = 0f;
            _pausePanel.gameObject.SetActive(true);
            isRunning = false;

        }
        else
        {
            Time.timeScale = 1f;
            _pausePanel.gameObject.SetActive(false);
            isRunning = true;
        }
    }

    

}
