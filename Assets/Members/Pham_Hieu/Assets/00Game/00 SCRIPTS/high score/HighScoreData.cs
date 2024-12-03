using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "HighScoreData", menuName = "HighScore/HighScoreData")]
public class HighScoHighScoreData : ScriptableObject
{
    public List<HighScoreEntry> highScores = new List<HighScoreEntry>();

    [System.Serializable]
    public class HighScoreEntry
    {
        public string playerName;
        public int score;

        public HighScoreEntry(string playerName, int score)
        {
            this.playerName = playerName;
            this.score = score;
        }
    }

    public void AddScore(string playerName, int score)
    {
        highScores.Add(new HighScoreEntry(playerName, score));
        highScores.Sort((a, b) => b.score.CompareTo(a.score)); // Sắp xếp theo điểm số giảm dần
    }

    public void ClearScores()
    {
        highScores.Clear();
    }
}
