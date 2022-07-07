using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackButton : MonoBehaviour
{
    [SerializeField] private Button _backButton;
    [SerializeField] private GameObject _mainMenuPanel;
    [SerializeField] private GameObject _settingsPanel;

    private void OnEnable()
    {
        _backButton.onClick.AddListener(BackToMenu);

    }

    private void OnDisable()
    {
        _backButton.onClick.RemoveAllListeners();
    }

    private void BackToMenu()
    {
        _mainMenuPanel.SetActive(true);
        _settingsPanel.SetActive(false);
    }
}
