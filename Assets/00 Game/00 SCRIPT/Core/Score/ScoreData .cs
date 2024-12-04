using UnityEngine;

public class ScoreData
{
    private int currentScore;
    private int highScore;

    public int CurrentScore
    {
        get => currentScore;
        set
        {
            currentScore = value;
            if (currentScore > highScore)
            {
                highScore = currentScore;
                PlayerPrefs.SetInt("HighScore", highScore);
                PlayerPrefs.Save();
            }
        }
    }

    public int HighScore => highScore;

    public ScoreData()
    {
        highScore = PlayerPrefs.GetInt("HighScore", 0);
        currentScore = 0;
    }
}
