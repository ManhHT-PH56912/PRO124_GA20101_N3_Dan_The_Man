using UnityEngine;
using Consts;

public class Playercolli : MonoBehaviour
{
<<<<<<< HEAD
    // [SerializeField] private ScoreController scoreController; // Kéo ScoreController từ Inspector
    // private int _score = 2;

    // private void OnTriggerEnter2D(Collider2D other)
    // {
    //     if (other.gameObject.CompareTag(Tags.PLAYER_TAG))
    //     {
    //         // Thêm điểm
    //         if (scoreController != null)
    //         {
    //             scoreController.AddScore(_score);
    //             Destroy(other.gameObject);
    //         }
    //         else
    //         {
    //             Debug.LogError("ScoreController chưa được gán trong Inspector!");
    //         }
    //     }
    // }
=======
    [SerializeField] private ScoreController scoreController; // Kéo ScoreController từ Inspector
    private int _score = 2;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag(Tags.PLAYER_TAG))
        {
            // Thêm điểm
            if (scoreController != null)
            {
                scoreController.AddScore(_score);
                Destroy(other.gameObject);
            }
            else
            {
                Debug.LogError("ScoreController chưa được gán trong Inspector!");
            }
        }
    }
>>>>>>> 6ed0cc495 (save and finish)
}
