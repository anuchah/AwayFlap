using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CoinEndRound : MonoBehaviour
{
    public static CoinEndRound instance;
    public Text coinOfRound;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        GetCoinAmount();
    }

    private void GetCoinAmount()
    {
        coinOfRound.text = CoinManager.instance.GetCoinScore().ToString();
    }
}
