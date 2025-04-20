using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    public GameObject explosionPrefab;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Asteroid"))
        {
            Instantiate(explosionPrefab, transform.position, Quaternion.identity);

            var scoreManager = FindFirstObjectByType<ScoreManager>();
            scoreManager.GameOver();

            // Salva a pontuação final
            int score = Mathf.FloorToInt(scoreManager.score);
            PlayerPrefs.SetInt("LastScore", score);

            Destroy(gameObject);

            SceneManager.LoadScene("GameOver");
        }
    }
}
