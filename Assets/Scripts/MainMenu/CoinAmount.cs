using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinAmount : MonoBehaviour
{
  
    public Text lastestCoin;

    void Start()
    {
        GetCoinAmount();
    }

    private void GetCoinAmount()
    {
        int coinAmount = PlayerPrefs.GetInt("TotalCoinsEarned", 0);
        lastestCoin.text = coinAmount.ToString();
    }
}
