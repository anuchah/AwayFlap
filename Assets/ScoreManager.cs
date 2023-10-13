using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int playerScore;
    public int highScore;
    public Text scoreText;
    public Text highScoreText;

    public Image barHighScore;
    public Text infoHighScore;
    private void Start()
    {
        highScore = PlayerPrefs.GetInt("Highscore", 0);
        highScoreText.text = highScore.ToString();
    }

    public void AddScore()
    {
        playerScore += 1;
        scoreText.text = playerScore.ToString();


        if (playerScore > highScore)
        {
            PlayerPrefs.SetInt("Highscore", playerScore);
            barHighScore.enabled = false;
            infoHighScore.enabled = false;
            highScoreText.enabled = false;
        }
    }
}
