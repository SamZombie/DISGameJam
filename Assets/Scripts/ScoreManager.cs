using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private int startingScore = 30;
    [SerializeField] private float scoreDecreaseRate = 1f;
    [SerializeField] public TMP_Text scoreText;

    private int currentScore;

    void Start()
    {
        currentScore = startingScore;
        UpdateScoreUI();
        InvokeRepeating(nameof(DecreaseScore), scoreDecreaseRate, scoreDecreaseRate);
    }

    void DecreaseScore()
    {
        if (currentScore > 0)
        {
            currentScore--;
            UpdateScoreUI();
        }
    }

    void UpdateScoreUI()
    {
        if (scoreText != null)
            scoreText.text = "Score: " + currentScore;
    }
}