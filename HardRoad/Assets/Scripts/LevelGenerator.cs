using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    [SerializeField]
    private GameObject[] wallPrefabs;
    [SerializeField]
    private float spawnTime;
    [SerializeField]
    private int poolSpawnAmount;

    private int currentPrefab;

    private void Awake()
    {
        PauseFeature.Pause();
    }

    private void Start()
    {
        PoolController.Preload(wallPrefabs[0], poolSpawnAmount);
        PoolController.Preload(wallPrefabs[1], poolSpawnAmount);
        PoolController.Preload(wallPrefabs[2], poolSpawnAmount);
        InvokeRepeating("SpawnWall", spawnTime, spawnTime);
    }

    private void SpawnWall()
    {
        currentPrefab = Random.Range(0, wallPrefabs.Length);
        var newWall = PoolController.Spawn(wallPrefabs[currentPrefab], transform.position, wallPrefabs[currentPrefab].transform.rotation);
    }
}
