using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    public static SpawnerScript instance;
    public GameObject[] platformPrefabs;
    public float spawnRate = 2;
    private float timer = 0;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        Instantiate(platformPrefabs[0], transform.position, Quaternion.identity);
    }

    private void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            SpawnerPlatform();
            timer = 0;
        }
    }

    private void SpawnerPlatform()
    {
        int randomPrefabIndex = Random.Range(0, platformPrefabs.Length);
        Instantiate(platformPrefabs[randomPrefabIndex], transform.position, Quaternion.identity);
    }
}
