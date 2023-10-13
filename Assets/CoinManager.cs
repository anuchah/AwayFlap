using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinManager : MonoBehaviour
{
    private static CoinManager instance;
    public int playerCoin;
    public Text scoreText;

    private void Awake()
    {
        if (!instance)
            instance = this;
    }

    public void Increment(int coin)
    {
        playerCoin += coin;
        scoreText.text = playerCoin.ToString();
    }
}
