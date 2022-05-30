using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EscPanel : MonoBehaviour
{
    [SerializeField] GameObject _escPanel;


    public void RestartOnClick()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }

    public void OpenEscPanel()
    {
        _escPanel.SetActive(true);
        Time.timeScale = 0;
    }

    public void CloseEscPanel()
    {
        _escPanel.SetActive(false);
        Time.timeScale = 1;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            OpenEscPanel();
        }
    }

    public void ExitOnClick()
    {
        Application.Quit();
    }

}
