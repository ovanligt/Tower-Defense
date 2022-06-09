using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static bool _gameIsOver = false;
    public GameObject GameOverUI;
    void Update()
    {
        if (_gameIsOver) return;

        if (PlayerParameters.Lives <= 0)
        {
            GameOver();
        }
    }

    private void GameOver() 
    {
        _gameIsOver = true;
        GameOverUI.SetActive(true);
        Debug.Log("Game Over");
    }
}
