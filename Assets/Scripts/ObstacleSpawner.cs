using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject obstaclePrefab;

    public float[] laneY = { -1.5f, 0f, 1.5f };

    public float spawnX = 8f;
    public float spawnDelay = 2.5f;

    void Start()
    {
        InvokeRepeating(nameof(SpawnObstacle), 1f, spawnDelay);
    }

    void SpawnObstacle()
    {
        for (int i = 0; i < 2; i++)
        {
            int randLane = Random.Range(0, laneY.Length);

            Vector3 spawnPos = new Vector3(spawnX, laneY[randLane], 0f);

            Instantiate(obstaclePrefab, spawnPos, Quaternion.identity);
        }
    }
}