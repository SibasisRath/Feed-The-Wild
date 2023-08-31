using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int _score = 0;
    private int _lives = 3;
    private int _maxScoreLoose = -5;

    public void AddLives(int value)
    {
        _lives += value;
        if (_lives <= 0)
        {
            Debug.Log("Game Over");
            _lives = 0;
        }
        Debug.Log("Lives = " + _lives);
    }
    public void AddScore(int value)
    {
        _score += value;
        Debug.Log("Score = " + _score);
        if (_score<=_maxScoreLoose)
        {
            Debug.Log("Game Over");
            _score = _maxScoreLoose;
        }
    }

}
