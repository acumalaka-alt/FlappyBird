using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipespawner : MonoBehaviour
{
    public GameObject pipe;  // Prefab pipe
    public float spawnTime;  // Cooldown spawn
    public float yPosMin, yPosMax;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnPipeCoroutine());
    }

    IEnumerator SpawnPipeCoroutine()
    {
        yield return new WaitForSeconds(spawnTime);
        Instantiate(pipe, transform.position + Vector3.up * UnityEngine.Random.Range(yPosMin, yPosMax), Quaternion.identity);
        StartCoroutine(SpawnPipeCoroutine());
    }
}
