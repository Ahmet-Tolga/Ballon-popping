using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloons : MonoBehaviour
{
    public GameObject[] balloonPrefabs;
    public Transform[] spawnpoints;
    public float timebtwspawns;
    float nextSpawn;

    void Start()
    {
        nextSpawn = Time.time + timebtwspawns;
    }

    void Update()
    {
        if (Time.time > nextSpawn)
        {
            SpawnBalloon();
            nextSpawn = Time.time + timebtwspawns;
        }
    }

    void SpawnBalloon()
    {
        int randomBalloonIndex = Random.Range(0, balloonPrefabs.Length);
        int randomSpawnIndex = Random.Range(0, spawnpoints.Length);

        Instantiate(balloonPrefabs[randomBalloonIndex], spawnpoints[randomSpawnIndex].position, Quaternion.identity);
    }
}
