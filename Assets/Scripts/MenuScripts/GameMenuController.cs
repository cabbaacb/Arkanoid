
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
       

    private void StartNewGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    private void ExitGame()
    {
        print("Exit");
        Application.Quit();
        //EditorApplication.isPlaying = false;
    }
}
