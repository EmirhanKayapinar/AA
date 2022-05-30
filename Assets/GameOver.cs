using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    [SerializeField] GameObject _gameOverPanel;
    [SerializeField] Text _scoreText;
    [SerializeField] GameObject _mainCamera;

    public void RestartOnClick()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }

    public void OpenEscPanel()
    {
        _gameOverPanel.SetActive(true);
        _scoreText.text = $"Skor : {_mainCamera.GetComponent<Score>()._score}";
    }

    
    

    public void ExitOnClick()
    {
        Application.Quit();
    }
}
