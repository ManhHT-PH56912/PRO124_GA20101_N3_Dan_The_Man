using UnityEngine;

public class GameConfig : MonoBehaviour
{
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    private void Update()
    {
        Application.targetFrameRate = 60;
    }
}
