using UnityEngine;

[CreateAssetMenu(fileName = "HighScoreData", menuName = "Game/HighScoreData")]

public class HighScoreData : ScriptableObject
{
    public int currentScore = 0; // Điểm hiện tại
    public int highScore = 0;   // Điểm cao nhất

    public void AddScore(string playerName, int points)
    {
        currentScore += points; // Cộng điểm mới vào điểm hiện tại
        if (currentScore > highScore)
        {
            highScore = currentScore; // Cập nhật điểm cao nhất nếu cần
        }
    }

    public void ResetScore()
    {
        currentScore = 0; // Đặt lại điểm hiện tại
    }
}
