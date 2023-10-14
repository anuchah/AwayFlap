using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreCurrent : MonoBehaviour
{
    public Text highScoreLastest;

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
