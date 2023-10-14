using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverScript : MonoBehaviour
{
    public void Replay()
    {
        SceneManager.LoadSceneAsync(1);
    }

    public void GoHome()
    {
        SceneManager.LoadSceneAsync(0);
    }
}
