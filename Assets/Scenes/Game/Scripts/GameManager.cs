using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private bool _gameOver = false;
    void Update()
    {
        if (_gameOver) return;
        if (PlayerParameters.Lives <= 0)
        {
            GameOver();
        }
    }

    private void GameOver() 
    {
        _gameOver = true;
        Debug.Log("Game Over");
    }
}
