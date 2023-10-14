using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CoinManager : MonoBehaviour
{
    public static CoinManager instance;
    public int playerCoin;
    public int roundCoinEarned; // Coins earned in the current round
    public int totalCoinsEarned; // Total coins earned across all rounds
    public TextMeshProUGUI scoreText;

    private void Awake()
    {
        instance = this;
        totalCoinsEarned = PlayerPrefs.GetInt("TotalCoinsEarned", 0);
        UpdateScoreText();
    }

    public void Increment(int coin)
    {
        playerCoin += coin;
        roundCoinEarned += coin; // Increment round coins
        UpdateScoreText();
        PlayerPrefs.SetInt("PlayerCoin", playerCoin);
        PlayerPrefs.Save();
    }

    private void UpdateScoreText()
    {
        scoreText.text = playerCoin.ToString();
    }

    public void EndRound()
    {
        // Call this method to end a round and add the roundCoinEarned to totalCoinsEarned
        totalCoinsEarned += roundCoinEarned;
        roundCoinEarned = 0; // Reset round coins
        PlayerPrefs.SetInt("TotalCoinsEarned", totalCoinsEarned);
        PlayerPrefs.Save();
    }
}
