using UnityEngine;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class MainMenu : MonoBehaviour
{
    public void LoginScreen()
    {
        SceneManager.LoadSceneAsync(Consts.Scene.AUTHENTICATION);
    }

    public void PlayGame()
    {
        SceneManager.LoadSceneAsync(Consts.Scene.MAP1);
    }

    public void OpenShop()
    {
        SceneManager.LoadSceneAsync(Consts.Scene.SHOP_SCREEN);
    }


    public void BaclMainMenu()
    {
        SceneManager.LoadSceneAsync(Consts.Scene.MAIN_MENU);
    }



    public void ExitGame()
    {
#if UNITY_EDITOR
        // Nếu đang ở trong Editor, dừng play mode
        if (EditorApplication.isPlaying)
        {
            EditorApplication.isPlaying = false;
        }
#else
        // Nếu là build game, thoát trò chơi
        Application.Quit();
#endif
    }
}
