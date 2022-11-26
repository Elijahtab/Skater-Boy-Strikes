using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupGenerator : MonoBehaviour
{
    [SerializeField]
    private Powerup[] powerupOptions;
    [SerializeField]
    private float spawnInterval;
    [SerializeField]
    private float minSpawnHeight;
    [SerializeField]
    private float maxSpawnHeight;

    private int numConfigs;
    private float timer;

    void Start()
    {
        timer = 0;
        numConfigs = powerupOptions.Length;
    }


    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= spawnInterval)
        {
            timer = 0;
            int nextPow = Random.Range(0, numConfigs);
            float nextHeight = Random.Range(minSpawnHeight, maxSpawnHeight);
            Vector2 spawnLoc = new Vector2(transform.position.x, nextHeight);

            GameObject newPow = Instantiate(powerupOptions[nextPow].gameObject,
                                                spawnLoc, transform.rotation);
        }
    }
}
