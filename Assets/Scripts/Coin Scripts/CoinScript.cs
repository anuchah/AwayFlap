using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    public static CoinScript instance;
    private CoinManager coinManager;
    private EagleScript player;
    public AudioManagerScript audioManager;
    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManagerScript>();
        coinManager = GameObject.FindGameObjectWithTag("Logic").GetComponent<CoinManager>();
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<EagleScript>();
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
