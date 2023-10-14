using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreEndRound : MonoBehaviour
{
     public Text scoreOfRound;

    void Start()
    {
        GetCoinAmount();
    }

    private void GetCoinAmount()
    {
        int coinAmount = PlayerPrefs.GetInt("PlayerScore", 0);
        scoreOfRound.text = coinAmount.ToString();
    }
}
