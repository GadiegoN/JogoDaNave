using UnityEngine;

public class StarSpawner : MonoBehaviour
{
    public GameObject starPrefab;
    public float spawnRate = 0.1f;
    public float minX = -3f, maxX = 3f;

    void Start()
    {
        InvokeRepeating(nameof(SpawnStar), 0f, spawnRate);
    }

    void SpawnStar()
    {
        float randomX = Random.Range(minX, maxX);
        Vector3 spawnPos = new Vector3(randomX, 6f, 0f); // Acima da tela
        Instantiate(starPrefab, spawnPos, Quaternion.identity);
    }
}
