using UnityEngine;

public class AddHighScore : MonoBehaviour
{
    public HighScoreData highScoreData;

    public void AddNewScore(string playerName, int score)
    {
        highScoreData.AddScore(playerName, score);
    }
}
