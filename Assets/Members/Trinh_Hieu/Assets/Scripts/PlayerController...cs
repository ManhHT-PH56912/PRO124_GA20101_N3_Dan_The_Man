using UnityEngine;


public class PlayerController : MonoBehaviour
{
    [Header("Movement Settings")]
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float jumpForce = 10f;

    [Header("Ground Check")]
    [SerializeField] private UnityEngine.Transform groundCheck;
    [SerializeField] private float groundCheckRadius = 0.2f;
    [SerializeField] private LayerMask whatIsGround;

    private Rigidbody2D rb;
    private Animator animator;
    private bool isGrounded;
    private int jumpCount = 0;
    private bool facingRight = true;
    private bool isAttacking = false;

    void Start()
    {
        // Cache Rigidbody và Animator
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    [System.Obsolete]
    void Update()
    {
        // Di chuyển trái phải
        float moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput * moveSpeed, rb.velocity.y);

        // Kiểm tra xem nhân vật có đứng trên mặt đất không
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);

        // Cập nhật trạng thái animator
        animator.SetBool("isGrounded", isGrounded);
        animator.SetFloat("moveSpeed", Mathf.Abs(moveInput));
        animator.SetInteger("jumpCount", jumpCount);

        // Nhảy (nhảy thường hoặc nhảy 2 lần)
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isGrounded || jumpCount < 2)
            {
                Jump();
            }
        }

        // Nhảy và đánh khi nhấn chuột trái
        if (Input.GetMouseButtonDown(0) && !isAttacking)
        {
            JumpAttack();
        }

        // Quay nhân vật theo hướng di chuyển
        if (moveInput > 0 && !facingRight)
        {
            Flip();
        }
        else if (moveInput < 0 && facingRight)
        {
            Flip();
        }
    }

    [System.Obsolete]
    void Jump()
    {
        rb.velocity = new Vector2(rb.velocity.x, jumpForce);

        if (isGrounded)
        {
            animator.SetTrigger("Jump"); // Nhảy lần đầu
            isGrounded = false;
            jumpCount = 1;
        }
        else if (jumpCount == 1)
        {
            animator.SetTrigger("DoubleJumpKick"); // Nhảy đá
            jumpCount++;
        }
    }

    [System.Obsolete]
    void JumpAttack()
    {
        rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        animator.SetTrigger("JumpAttack");
        isAttacking = true;
        Invoke(nameof(ResetAttack), 0.5f); // Reset trạng thái tấn công sau 0.5 giây
    }

    void ResetAttack()
    {
        isAttacking = false;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Kiểm tra chạm đất
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
            jumpCount = 0;
        }
    }

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 scaler = transform.localScale;
        scaler.x *= -1;
        transform.localScale = scaler;
    }
}



