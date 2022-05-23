using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool _gameHasEnded = false;
    [SerializeField] Rotator _rotator;
    [SerializeField] Spawner _spawner;
    [SerializeField] Animator _anim;
    public void EndGame()
    {

        if (_gameHasEnded)
        {
            return;
        }
        _rotator.enabled = false;
        _spawner.enabled = false;
        _anim.SetTrigger("EndGame");
        _gameHasEnded = true;
        Debug.Log("bitti");
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    

}
