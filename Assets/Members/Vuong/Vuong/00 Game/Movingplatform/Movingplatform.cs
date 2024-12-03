using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public float tocDoDiChuyen = 1f; // Movement speed
    public Transform start; // Starting position
    public Transform end; // Ending position
    private Vector2 mucTieu; // Current target
    private bool isMovingToStart = true;

    void Start()
    {
        // Ensure initial target is set correctly
        if (start != null)
        {
            mucTieu = start.position;
        }
        else
        {
            Debug.LogError("Start Transform is not assigned.");
        }

        if (end == null)
        {
            Debug.LogError("End Transform is not assigned.");
        }
    }

    void Update()
    {
        if (start == null || end == null)
        {
            return; // Exit update if necessary references are missing
        }

        // Check and switch targets based on proximity
        if (isMovingToStart)
        {
            if (Vector2.Distance(transform.position, start.position) < 0.1f)
            {
                isMovingToStart = false;
                mucTieu = end.position;
            }
        }
        else
        {
            if (Vector2.Distance(transform.position, end.position) < 0.1f)
            {
                isMovingToStart = true;
                mucTieu = start.position;
            }
        }

        // Move the platform smoothly
        transform.position = Vector2.MoveTowards(transform.position, mucTieu, tocDoDiChuyen * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            // Attach the player to the platform
            collision.transform.SetParent(transform);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            // Detach the player from the platform
            collision.transform.SetParent(null);
        }
    }
}
