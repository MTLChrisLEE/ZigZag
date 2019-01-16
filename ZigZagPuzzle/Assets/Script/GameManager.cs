﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public bool gameStarted;
    public int score;
    public Text scoreText;

    public void StartGame()
    {
        gameStarted = true;
    }

    public void EndGame()
    {
        SceneManager.LoadScene(0);
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            StartGame();
        }
    }

    public void IncreaseScore()
    {
        score++;
        print(score.ToString());
        scoreText.text = score.ToString();
    }

}
