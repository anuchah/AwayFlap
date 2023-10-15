using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HighScoreCurrent : MonoBehaviour
{
    public TextMeshProUGUI highScoreLastest;

    void Start()
    {
        GetHighScore();
    }

    private void GetHighScore()
    {
        int highScore = PlayerPrefs.GetInt("Highscore", 0);
        highScoreLastest.text = highScore.ToString();
    }
}
