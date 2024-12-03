// using UnityEngine;

// public class PlayerTestst : MonoBehaviour
// {
//     public float jumpForce = 10f;
//     public Transform punchPoint;  // Vị trí mà cú đấm sẽ xuất phát
//     public float punchRange = 0.5f; // Phạm vi đấm
//     public LayerMask enemyLayers; // Lớp đối tượng có thể bị đấm
//     public int punchDamage = 10; // Sát thương của cú đấm

//     private Rigidbody2D rb;
//     private bool isGrounded = false;

//     void Start()
//     {
//         rb = GetComponent<Rigidbody2D>();
//     }

//     void Update()
//     {
//         HandleJump();
//         HandlePunch();
//     }

//     [System.Obsolete]
//     void HandleJump()
//     {
//         if (Input.GetButtonDown("Jump") && isGrounded)
//         {
//             rb.velocity = new Vector2(rb.velocity.x, jumpForce);
//             isGrounded = false;
//         }
//     }

//     void HandlePunch()
//     {
//         if (Input.GetButtonDown("Fire1")) // "Fire1" mặc định là chuột trái hoặc nút Ctrl
//         {
//             Punch();
//         }
//     }

//     void Punch()
//     {
//         Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(punchPoint.position, punchRange, enemyLayers);

//         foreach (Collider2D enemy in hitEnemies)
//         {
//             Debug.Log("Đấm trúng: " + enemy.name);
//             enemy.GetComponent<Enemy>().TakeDamage(punchDamage); // Giả sử đối tượng Enemy có hàm TakeDamage
//         }
//     }

//     private void OnCollisionEnter2D(Collision2D collision)
//     {
//         if (collision.contacts[0].normal.y > 0.5f)
//         {
//             isGrounded = true;
//         }
//     }

//     void OnDrawGizmosSelected()
//     {
//         if (punchPoint == null)
//             return;

//         Gizmos.DrawWireSphere(punchPoint.position, punchRange);
//     }
// }