using TMPro;
using UnityEngine;

public class GameOverManager : MonoBehaviour
{
    public TextMeshProUGUI finalScoreText;

    void Start()
    {
        int score = PlayerPrefs.GetInt("LastScore", 0);
        finalScoreText.text = $"Pontuação final: {score}";
    }
}
