using UnityEngine;

public class ScoreController : MonoBehaviour
{
    private ScoreData model;
    private ScoreView view;

    [System.Obsolete]
    private void Awake()
    {
        model = new ScoreData();
        view = FindObjectOfType<ScoreView>();
        
        if (view == null)
        {
            Debug.LogError("ScoreView not found in scene!");
        }
    }

    private void Start()
    {
        UpdateUI();
    }

    public void AddScore(int points)
    {
        model.CurrentScore += points;
        UpdateUI();
    }

    public void ResetScore()
    {
        model.CurrentScore = 0;
        UpdateUI();
    }

    private void UpdateUI()
    {
        view.UpdateScoreDisplay(model.CurrentScore, model.HighScore);
    }
}