using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class GameMenuController : MonoBehaviour
{
    [SerializeField] private GameObject _gameMenuPanel;
    [SerializeField] private Button _newGameButton;
    [SerializeField] private Button _exitButton;




    // Start is called before the first frame update
    void Start()
    {
        _newGameButton.onClick.AddListener(StartNewGame);
        _exitButton.onClick.AddListener(ExitGame);
    }

    private void OnDestroy()
    {
        _newGameButton.onClick.RemoveAllListeners();
        _exitButton.onClick.RemoveAllListeners();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void StartNewGame()
    {

    }

    private void ExitGame()
    {
        print("Exit");
        Application.Quit();
        //EditorApplication.isPlaying = false;
    }
}
