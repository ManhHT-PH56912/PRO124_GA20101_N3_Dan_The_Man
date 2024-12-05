using UnityEngine;

<<<<<<< HEAD
public class CheckPoint : MonoBehaviour
{
=======

public class CheckPoint : MonoBehaviour
{
    public GameObject player;
>>>>>>> 6ed0cc495 (save and finish)
    private RespawnScript respawn;
    private BoxCollider2D checkpointCollder;
    private void Awake()
    {
        checkpointCollder = GetComponent<BoxCollider2D>();
        respawn = GameObject.FindGameObjectWithTag("Respawn").GetComponent<RespawnScript>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("player")) 
        {
            respawn.RespawnPoint = this.gameObject;
            checkpointCollder.enabled = false;
        }
    }
         
}
