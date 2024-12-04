// View/ScoreView.cs
using UnityEngine;
using TMPro;

public class ScoreView : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI currentScoreText;
    [SerializeField] private TextMeshProUGUI highScoreText;

    private void Awake()
    {
        if (currentScoreText == null || highScoreText == null)
        {
            Debug.LogError("TextMeshPro components not assigned to ScoreView!");
        }
    }

    public void UpdateScoreDisplay(int currentScore, int highScore)
    {
        currentScoreText.text = currentScore.ToString();
        highScoreText.text = highScore.ToString();
    }
}