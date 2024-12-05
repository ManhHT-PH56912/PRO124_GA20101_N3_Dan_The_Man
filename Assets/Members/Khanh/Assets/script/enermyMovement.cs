<<<<<<< HEAD
using UnityEngine;

public class EnermyMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
=======
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enermyMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

>>>>>>> 6ed0cc495 (save and finish)
    public float enemySpeed;

    Rigidbody2D enemyRB;
    Animator enemyAnim;

    public GameObject enemyGraphic;
    bool facingRight = false;
    float facingTime = 5f;
    float nextFlip = 0f;
    bool canFlip = true;
<<<<<<< HEAD
    private Health playerHealth;

    void Awake()
    {
        playerHealth = GetComponent<Health>();
=======

    void Awake()
    {
>>>>>>> 6ed0cc495 (save and finish)
        enemyRB = GetComponent<Rigidbody2D>();
        enemyAnim = GetComponentInChildren<Animator>();
    }

<<<<<<< HEAD
=======
    void Start()
    {
        
    }

>>>>>>> 6ed0cc495 (save and finish)
    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextFlip)
        {
            nextFlip = Time.time + facingTime;
<<<<<<< HEAD
            flip();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
      if (collision.gameObject.CompareTag(Consts.Tags.PLAYER_TAG))
        {
            playerHealth.TakeDame(10);
            Destroy(collision.gameObject, 0.5f);
        }
    }

    protected void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            if (facingRight && other.transform.position.x < transform.position.x)
            {
                flip();
            }
            else if (!facingRight && other.transform.position.x > transform.position.x)
            { flip(); }
=======
            flip ();
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            if (facingRight && other.transform.position.x < transform.position.x) 
            {
                flip();
            }else if(!facingRight && other.transform.position.x > transform.position.x)
            {  flip();}
>>>>>>> 6ed0cc495 (save and finish)

            canFlip = false;
        }
    }

<<<<<<< HEAD
    private void OnTriggerStay2D(Collider2D other)
    {

        if (other.tag == "Player")
        {
            if (!facingRight)
                enemyRB.AddForce(new Vector2(-1, 0) * enemySpeed);
            else enemyRB.AddForce(new Vector2(1, 0) * enemySpeed);
            enemyAnim.SetBool("Run", true);
            // Set Annim
            Destroy(this.gameObject, 2f);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
=======
    void OnTriggerStay2D(Collider2D other)
    {
        if(other.tag == "Player")
        { if(!facingRight)  
                enemyRB.AddForce(new Vector2(-1, 0) * enemySpeed);
          else enemyRB.AddForce(new Vector2(1,0)* enemySpeed);
            enemyAnim.SetBool("Run", true);
        }
    }

    void OnTriggerExit2D(Collider2D other)
>>>>>>> 6ed0cc495 (save and finish)
    {
        if (other.tag == "Player")
        {
            canFlip = true;
<<<<<<< HEAD
            enemyRB.linearVelocity = new Vector2(0, 0);
            enemyAnim.SetBool("Run", false);
        }
    }

    private void flip()
=======
            enemyRB.linearVelocity = new Vector2 (0, 0);
            enemyAnim.SetBool ("Run", false);
        }
    }
    void flip()
>>>>>>> 6ed0cc495 (save and finish)
    {
        if (!canFlip)
            return;
        facingRight = !facingRight;
        Vector3 theScale = enemyGraphic.transform.localScale;
        theScale.x *= -1;
        enemyGraphic.transform.localScale = theScale;
    }
}
