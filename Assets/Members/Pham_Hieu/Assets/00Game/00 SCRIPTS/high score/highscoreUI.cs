using UnityEngine;
using UnityEngine.UI;

public class HighScoreUI : MonoBehaviour
{
    public HighScoreData highScoreData; // Tham chiếu đến Scriptable Object
    public Text highScoreText;         // UI Text để hiển thị danh sách high scores

    void Start()
    {
        UpdateHighScoreUI();
    }

    public void UpdateHighScoreUI()
    {
        highScoreText.text = ""; // Xóa nội dung cũ
        // foreach (var entry in highScoreData.highScore) // Lỗi fix nhé 
        // {
        //     highScoreText.text += $"{entry.playerName}: {entry.score}\n";
        // }
    }
}
