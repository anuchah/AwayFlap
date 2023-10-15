using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CoinAmount : MonoBehaviour
{
    public TextMeshProUGUI totalCoinsText;

    private void Start()
    {
        GetCoins();
    }

    public void GetCoins()
    {
        totalCoinsText.text = PlayerPrefs.GetInt("TotalScore", 0).ToString();
    }
}
