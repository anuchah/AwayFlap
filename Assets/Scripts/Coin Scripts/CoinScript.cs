using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    public static CoinScript instance;
    private CoinManager coinManager;
    private AudioManagerScript audioManager;
    private EagleScript player;
    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        coinManager = GameObject.FindGameObjectWithTag("Logic").GetComponent<CoinManager>();
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<EagleScript>();
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManagerScript>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == 3 && player.isAlive)
        {
            coinManager.CollectCoin();
            audioManager.PlaySFX(audioManager.pickUpcoins);
            Destroy(gameObject);
        }
    }
}
