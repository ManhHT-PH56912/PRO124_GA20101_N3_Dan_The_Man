using UnityEngine;

public class checkpoint : MonoBehaviour
{
    private RespawnScript respawn;
    private BoxCollider2D checkpointcollider;

    private void Awake()
    {
        checkpointcollider = GetComponent<BoxCollider2D>();
        respawn = GameObject.FindGameObjectWithTag("Respawn").GetComponent<RespawnScript>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player")) 
        {
            respawn.RespawnPoint = this.gameObject;
            checkpointcollider.enabled = false;
        }
    }
}
