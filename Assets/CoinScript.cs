using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    private CoinManager coinManager;
    private void Start()
    {
        coinManager = GameObject.FindGameObjectWithTag("Logic").GetComponent<CoinManager>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == 3)
        {
            coinManager.Increment(1);
            Destroy(gameObject);
        }
    }
}
