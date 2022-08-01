using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameMenuController : MonoBehaviour
{
    [SerializeField] private Button _settingsButton;
    [SerializeField] private Button _newGameButton;
    [SerializeField] private Button _exitButton;
    [SerializeField] private GameObject _mainMenuPanel;
    [SerializeField] private GameObject _settingsPanel;



    // Start is called before the first frame update
    void Start()
    {
        _newGameButton.onClick.AddListener(StartNewGame);
        _exitButton.onClick.AddListener(ExitGame);
        _settingsButton.onClick.AddListener(OpenSettingsPanel);
    }

    private void OnDestroy()
    {
        _newGameButton.onClick.RemoveAllListeners();
        _exitButton.onClick.RemoveAllListeners();
        _settingsButton.onClick.RemoveAllListeners();
    }
       

    private void StartNewGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    private void ExitGame()
    {
        print("Exit");
        Application.Quit();
        //UnityEditor.EditorApplication.isPlaying = false;
    }

    private void OpenSettingsPanel()
    {
        _settingsPanel.SetActive(true);
        _mainMenuPanel.SetActive(false);
    }
}
