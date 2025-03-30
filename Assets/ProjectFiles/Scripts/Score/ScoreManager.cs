using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    protected static int score = 0;
    [SerializeField] private Text scoreText;

    public void AddScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score: " + score;
    }
    public void RemoveScore(int scoreToRemove)
    {
        if (score >= scoreToRemove)
        {
            score -= scoreToRemove;
            scoreText.text = "Score: " + score;
        }
    }
    public void ShowScore()
    {
        Debug.Log("Score: " + score);
    }
}
