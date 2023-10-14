using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    public static ScoreManager instance;
    public int playerScore = 0;
    public int highScore;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highScoreText;
    public Image barHighScore;
    public TextMeshProUGUI infoHighScore;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        highScore = PlayerPrefs.GetInt("Highscore", 0);
        highScoreText.text = highScore.ToString();
    }

    public void AddScore(int score)
    {
        playerScore += score;
        scoreText.text = playerScore.ToString();

        if (playerScore > highScore)
        {
            highScore = playerScore; // Update the high score for the current round
            PlayerPrefs.SetInt("Highscore", highScore);
            PlayerPrefs.Save();
            RemoveBarHighScore();
        }
    }

    public void EndRound()
    {
        PlayerPrefs.SetInt("PlayerScore", playerScore);
        PlayerPrefs.Save();

        // Reset the player's score for the next round
        playerScore = 0;
    }

    private void RemoveBarHighScore()
    {
        highScoreText.enabled = false;
        barHighScore.enabled = false;
        infoHighScore.enabled = false;
    }
}
