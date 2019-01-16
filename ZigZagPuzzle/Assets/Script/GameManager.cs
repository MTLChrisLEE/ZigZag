using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public bool gameStarted;
    public int score;
    public Text scoreText;
    public Text highscoreText;

    private void Awake()
    {
        highscoreText.text = "BEST: " + GetHighScore().ToString();
    }

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

        if (score > GetHighScore())
        {
            PlayerPrefs.SetInt("Highscore",score);
            highscoreText.text = "BEST: " + score.ToString();
        }

    }

    public int GetHighScore()
    {
        return PlayerPrefs.GetInt("Highscore");
    }

}
