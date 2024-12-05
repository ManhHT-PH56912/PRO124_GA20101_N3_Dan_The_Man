using UnityEngine;

public class RespawnScript : MonoBehaviour
{
    public GameObject player;
    public GameObject RespawnPoint;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
<<<<<<< HEAD
    
=======
>>>>>>> 6ed0cc495 (save and finish)
    private void OnTriggerEnter2D(Collider2D collision)
    {
        player.transform.position = RespawnPoint.transform.position;
    }
}
