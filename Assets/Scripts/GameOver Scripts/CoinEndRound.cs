using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinEndRound : MonoBehaviour
{
    public Text coinOfRound;

    void Start()
    {
        GetCoinAmount();
    }

    private void GetCoinAmount()
    {
        int coinAmount = PlayerPrefs.GetInt("PlayerCoin", 0);
        coinOfRound.text = coinAmount.ToString();
    }
}
