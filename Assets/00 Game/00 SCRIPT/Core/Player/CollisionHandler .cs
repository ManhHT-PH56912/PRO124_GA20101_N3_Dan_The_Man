using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
<<<<<<< HEAD
    [SerializeField] private int scoreValue = 2; // Giá trị điểm cộng thêm khi va chạm

    [System.Obsolete]
=======
    [SerializeField] private ScoreController scoreController; // Tham chiếu đến ScoreController
    [SerializeField] private int scoreValue = 1; // Giá trị điểm cộng thêm khi va chạm
>>>>>>> 6ed0cc495 (save and finish)
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Kiểm tra va chạm với đối tượng có Tag "Coins"
        if (collision.CompareTag("Coins"))
        {
<<<<<<< HEAD
            GameManager.Instance.OnPlayerScored(scoreValue);
=======
            scoreController.AddScore(scoreValue); // Gọi hàm cộng điểm
            Destroy(gameObject);     // Xóa vật thể sau khi va chạm
>>>>>>> 6ed0cc495 (save and finish)
        }
    }
}
