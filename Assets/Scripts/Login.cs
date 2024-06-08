using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Login : MonoBehaviour
{
    public InputField usernameInput;
    public InputField passwordInput;
    public Button loginButton;
    public Button goToRegisterButton;

    ArrayList credentials;

    // Start is called before the first frame update
    void Start()
    {
        loginButton.onClick.AddListener(login);
        goToRegisterButton.onClick.AddListener(moveToRegister);

        if (File.Exists(Application.persistentDataPath + "/credentials.txt"))
        {
            credentials = new ArrayList(File.ReadAllLines(Application.persistentDataPath + "/credentials.txt"));
        }
        else
        {
            Debug.Log("Credential file doesn't exist");
        }
    }

    // Update is called once per frame
    void login()
    {
        bool isExists = false;

        credentials = new ArrayList(File.ReadAllLines(Application.persistentDataPath + "/credentials.txt"));

        foreach (var i in credentials)
        {
            string line = i.ToString();
            if (line.Substring(0, line.IndexOf(":")).Equals(usernameInput.text) &&
                line.Substring(line.IndexOf(":") + 1).Equals(passwordInput.text))
            {
                isExists = true;
                break;
            }
        }

        if (isExists)
        {
            // Debug.Log($"Logging in '{usernameInput.text}'");
            loadWelcomeScreen();
        }
        else
        {
            // Debug.Log("Incorrect credentials");
            SceneManager.LoadScene("Incorrect");
        }
    }

    void moveToRegister()
    {
        SceneManager.LoadScene("Register");
    }

    void loadWelcomeScreen()
    {
        SceneManager.LoadScene("WelcomeScreen");
    }
}
