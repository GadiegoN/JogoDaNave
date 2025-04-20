using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{
    public GameObject asteroidPrefab;
    public float spawnRate = 1f;
    public float minX = -2.5f, maxX = 2.5f;

    void Start()
    {
        InvokeRepeating(nameof(SpawnAsteroid), 1f, spawnRate);
    }

    void SpawnAsteroid()
    {
        float randomX = Random.Range(minX, maxX);
        Vector3 spawnPos = new Vector3(randomX, 6f, 0f);
        Instantiate(asteroidPrefab, spawnPos, Quaternion.identity);
    }
}
