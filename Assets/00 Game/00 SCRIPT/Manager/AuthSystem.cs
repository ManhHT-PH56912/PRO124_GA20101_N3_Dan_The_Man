using System.Collections;
using TMPro;
using UnityEngine;

public class AuthSystem : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI TopText;
    [SerializeField] TextMeshProUGUI MessengerText;
<<<<<<< HEAD

=======
    
>>>>>>> 6ed0cc495 (save and finish)
    [Header("Login")]
    [SerializeField] TMP_InputField EmailLogin;
    [SerializeField] TMP_InputField PassLogin;
    [SerializeField] GameObject LoginPage;

    [Header("Register")]
    [SerializeField] TMP_InputField UserRegister;
    [SerializeField] TMP_InputField EmailRegister;
    [SerializeField] TMP_InputField PasswordsRegister;
    [SerializeField] GameObject RegisterPage;

<<<<<<< HEAD
    // void Start()
    // {
    //     PlayerPrefs.DeleteAll();
    // }
=======
    void Start()
    {
        PlayerPrefs.DeleteAll();
    }
>>>>>>> 6ed0cc495 (save and finish)

    public void OpenLogin()
    {
        LoginPage.SetActive(true);
        RegisterPage.SetActive(false);
        TopText.text = "Login";
    }

    public void OpenRegister()
    {
        LoginPage.SetActive(false);
        RegisterPage.SetActive(true);
        TopText.text = "Register";
    }

<<<<<<< HEAD
    [System.Obsolete]
=======
>>>>>>> 6ed0cc495 (save and finish)
    public void LoginProcess()
    {
        string email = EmailLogin.text;
        string password = PassLogin.text;

        if (PlayerPrefs.HasKey(email))
        {
            string storedPassword = PlayerPrefs.GetString(password);

            if (storedPassword == password)
            {
                MessengerText.text = "Đăng nhập thành công!";
                StartCoroutine(LoadScene());
            }
            else
            {
                MessengerText.text = "Sai mật khẩu!";
            }
        }
    }

<<<<<<< HEAD
    [System.Obsolete]
=======
>>>>>>> 6ed0cc495 (save and finish)
    public void RegisterProcess()
    {
        string username = UserRegister.text;
        string email = EmailRegister.text;
        string password = PasswordsRegister.text;
        if (PlayerPrefs.HasKey(username))
        {
            MessengerText.text = "Tên tài khoản đã tồn tại!";
        }
        else if (PlayerPrefs.HasKey(email))
        {
            MessengerText.text = "Email đã tồn tại!";
        }
        else
        {
            PlayerPrefs.SetString(username, username);
            PlayerPrefs.SetString(email, email);
            PlayerPrefs.SetString(password, password);
            PlayerPrefs.Save();
            MessengerText.text = "Đăng ký thành công!";
<<<<<<< HEAD
            // GameManager.Instance.OnLogginAccount(); // Xóa Score Data
=======
>>>>>>> 6ed0cc495 (save and finish)
            StartCoroutine(HideNotification());
            OpenLogin();
        }
    }

    IEnumerator LoadScene()
    {
<<<<<<< HEAD
        yield return new WaitForSeconds(1);
=======
        yield return new WaitForSeconds(1);    
>>>>>>> 6ed0cc495 (save and finish)
        MainMenu.BaclMainMenu();
    }

    IEnumerator HideNotification()
    {
        yield return new WaitForSeconds(0.2f);
        MessengerText.text = "";
    }
}
