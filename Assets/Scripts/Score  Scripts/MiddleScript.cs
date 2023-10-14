using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiddleScript : MonoBehaviour
{
    public static MiddleScript instance;
    public ScoreManager scoreManager;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        scoreManager = GameObject.FindGameObjectWithTag("Logic").GetComponent<ScoreManager>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == 3)
        {
            scoreManager.AddScore(1);
        }
    }
}
