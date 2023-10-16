using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiddleScript : MonoBehaviour
{
    public static MiddleScript instance;
    public ScoreManager scoreManager;
    private EagleScript player;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        scoreManager = GameObject.FindGameObjectWithTag("Logic").GetComponent<ScoreManager>();
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<EagleScript>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player" && player.isAlive)
        {
            scoreManager.AddScore(1);
        }
    }
}
