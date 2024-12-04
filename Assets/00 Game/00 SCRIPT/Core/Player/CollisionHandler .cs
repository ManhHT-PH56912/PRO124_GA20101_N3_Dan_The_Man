using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    [SerializeField] private ScoreController scoreController; // Tham chiếu đến ScoreController
    [SerializeField] private int scoreValue = 1; // Giá trị điểm cộng thêm khi va chạm
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Kiểm tra va chạm với đối tượng có Tag "Coins"
        if (collision.CompareTag("Coins"))
        {
            scoreController.AddScore(scoreValue); // Gọi hàm cộng điểm
            Destroy(gameObject);     // Xóa vật thể sau khi va chạm
        }
    }
}
