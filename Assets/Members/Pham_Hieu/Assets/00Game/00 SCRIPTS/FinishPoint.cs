using UnityEngine;

public class FinishPoint : MonoBehaviour
{
<<<<<<< HEAD
    
=======
    [SerializeField] bool goNextLevel;
    [SerializeField] string levelName;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (goNextLevel)
            {
                CustomSceneManager.instance.NextLevel();
            }
            else
            {
                if (!string.IsNullOrEmpty(levelName))
                {
                    CustomSceneManager.instance.LoadScene(levelName);
                }
                else
                {
                    Debug.LogError("Level name is empty or null!");
                }
            }
        }
    }
>>>>>>> 6ed0cc495 (save and finish)
}
