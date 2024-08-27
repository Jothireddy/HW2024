using UnityEngine;
using System.Collections;

public class PulpitManager : MonoBehaviour
{
    public GameObject pulpitPrefab;
    private GameConfig config;
    private Vector3 lastPulpitPosition = Vector3.zero;
    private float pulpitWidth = 5f; // This matches the x-scale of your pulpit (scale 2 on x-axis)

    void Start()
    {
        config = FindObjectOfType<GameConfig>();
        StartCoroutine(SpawnPulpits());
    }

    IEnumerator SpawnPulpits()
    {
        while (true)
        {
            Vector3 spawnPosition = GetNextPulpitPosition(lastPulpitPosition);
            lastPulpitPosition = spawnPosition;

            GameObject pulpit = Instantiate(pulpitPrefab, spawnPosition, Quaternion.identity);

            float pulpitLifetime = Random.Range(config.pulpitData.minPulpitDestroyTime, config.pulpitData.maxPulpitDestroyTime);
            Destroy(pulpit, pulpitLifetime);

            yield return new WaitForSeconds(config.pulpitData.pulpitSpawnTime);
        }
    }

    Vector3 GetNextPulpitPosition(Vector3 lastPosition)
    {
        // Define possible directions: left, right, and forward
        Vector3[] directions = new Vector3[]
        {
            new Vector3(-pulpitWidth, 0, 0),  // Left
            new Vector3(pulpitWidth, 0, 0),   // Right
            new Vector3(0, 0, pulpitWidth)    // Forward
        };

        // Pick a random direction
        int randomIndex = Random.Range(0, directions.Length);
        Vector3 randomDirection = directions[randomIndex];

        // Calculate and return the new position
        return lastPosition + randomDirection;
    }
}
