using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public HighScoreData highScoreData; // Tham chiếu đến Scriptable Object

    public int coinPoints = 10;  // Điểm nhận được khi nhặt coin
    public int enemyPoints = 50; // Điểm nhận được khi tiêu diệt enemy
    public string playerName = "Player1"; // Tên người chơi (có thể cập nhật từ UI)

    public void CollectCoin()
    {
        highScoreData.AddScore(playerName, coinPoints); // Truyền cả tên và điểm
        Debug.Log($"Coin collected! Current Score: {highScoreData.currentScore}");
    }

    public void DestroyEnemy()
    {
        highScoreData.AddScore(playerName, enemyPoints); // Truyền cả tên và điểm
        Debug.Log($"Enemy destroyed! Current Score: {highScoreData.currentScore}");
    }
}
