using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CoinManager : MonoBehaviour
{
    public static CoinManager instance;
    public TextMeshProUGUI coinScoreText; // Reference to the Text UI element
    public int coinScore = 0;
    public int totalScore = 0;
    private int totalTempScore = 0;

    private void Awake()
    {
        if (instance == null)
            instance = this;
    }

    private void Start()
    {
        totalScore = PlayerPrefs.GetInt("TotalScore", 0);
        UpdateCoinScoreText();
    }

    public void CollectCoin()
    {
        coinScore++;
        totalTempScore++;
        UpdateCoinScoreText();
    }

    public int GetCoinScore()
    {
        return coinScore;
    }

    private void UpdateCoinScoreText()
    {
        if (coinScoreText != null)
        {
            coinScoreText.text = coinScore.ToString();
        }
    }

    public void EndRound()
    {
        totalScore += totalTempScore;
        totalTempScore = 0;
        PlayerPrefs.SetInt("TotalScore", totalScore);
        PlayerPrefs.Save();
    }
}
