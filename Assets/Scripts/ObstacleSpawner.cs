using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject obstaclePrefab;

    public GameObject[] obstacleInstances;
    public int numberofInstances = 10;
    public int instanceIndex = 0;
    public float timeMin = 1f;
    public float timeMax = 2f;
    public float timeToSpawn = 0f;

    void Start() {
        obstacleInstances = new GameObject[numberofInstances];

        for (int i = 0; i < numberofInstances; i++) {
            obstacleInstances[i] = Instantiate(obstaclePrefab);
            obstacleInstances[i].transform.position = transform.position;
            obstacleInstances[i].SetActive(false);
        }
    }

    void Update()
    {
        timeToSpawn -= Time.deltaTime;

        if (timeToSpawn < 0.0f)
        {
            SpawnObstacle();
            timeToSpawn = Random.Range(timeMin, timeMax);
        }
    }

    void SpawnObstacle()
    {
        obstacleInstances[instanceIndex].SetActive(true);
        obstacleInstances[instanceIndex].transform.position = transform.position;
        instanceIndex++;

        if (instanceIndex == numberofInstances) instanceIndex = 0;

    }
}
