using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AuthSystem : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI TopText;
    [SerializeField] TextMeshProUGUI MessengerText;
    [Header("Login")]
    [SerializeField] TMP_InputField EmailLogin;
    [SerializeField] TMP_InputField PassLogin;
    [SerializeField] GameObject LoginPage;
    [Header("Register")]
    [SerializeField] TMP_InputField UserRegister;
    [SerializeField] TMP_InputField EmailRegister;
    [SerializeField] TMP_InputField PasswordsRegister;  
    [SerializeField] GameObject RegisterPage;

    void Start()
    {
        PlayerPrefs.DeleteAll();
    }

    public void OpenLogin(){
        LoginPage.SetActive(true);
        RegisterPage.SetActive(false);
        TopText.text = "Login";
    }

    public void OpenRegister(){

        LoginPage.SetActive(false);
        RegisterPage.SetActive(true);
        TopText.text = "Register";
    }

    public void LoginProcess(){
        string email = EmailLogin.text; // gia tri chung ta nhap vao truong input
        string password = PassLogin.text;
        
        if (PlayerPrefs.HasKey(email))
        {
            string storedPassword = PlayerPrefs.GetString(password);
            
            if (storedPassword == password)
            {
                MessengerText.text = "Đăng nhập thành công!";
                // Chuyển sang màn hình chính hoặc thực hiện logic khác
                StartCoroutine(loadScene(Consts.Scene.MAIN_MENU));
            }
            else
            {
                MessengerText.text = "Sai mật khẩu!";
            }
        }
    }

    public void RegisterProcess(){
        string username = UserRegister.text;
        string email = EmailRegister.text;
        string password = PasswordsRegister.text;
        if (PlayerPrefs.HasKey(username))
        {
            MessengerText.text = "Tên tài khoản đã tồn tại!";
        }else if(PlayerPrefs.HasKey(email)){
            MessengerText.text = "Email đã tồn tại!";
        }
        else
        {
            PlayerPrefs.SetString(username, username);
            PlayerPrefs.SetString(email, email);
            PlayerPrefs.SetString(password, password);
            PlayerPrefs.Save();
            MessengerText.text = "Đăng ký thành công!";
            StartCoroutine(HideNotification());
            OpenLogin();
        }
    }

    IEnumerator loadScene(string MAIN_MENU)
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(MAIN_MENU);
    }

    IEnumerator HideNotification(){
        yield return new WaitForSeconds(0.2f);
        MessengerText.text ="";
    }
}