using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Register : MonoBehaviour
{
    public InputField firstName;
    public InputField lastName;

    public InputField usernameInput;
    public InputField passwordInput;
    public Button registerButton;
    public Button goToLoginButton;

    ArrayList credentials;

    // Start is called before the first frame update
    void Start()
    {
        registerButton.onClick.AddListener(writeStuffToFile);
        goToLoginButton.onClick.AddListener(goToLoginScene);

        if (File.Exists(Application.persistentDataPath + "/credentials.txt"))
        {
            credentials = new ArrayList(File.ReadAllLines(Application.persistentDataPath + "/credentials.txt"));
        }
        else
        {
            File.WriteAllText(Application.persistentDataPath + "/credentials.txt", "");
        }

    }

    void goToLoginScene()
    {
        SceneManager.LoadScene("Login");
    }


    void writeStuffToFile()
    {
        bool isExists = false;

        credentials = new ArrayList(File.ReadAllLines(Application.persistentDataPath + "/credentials.txt"));
        foreach (var i in credentials)
        {
            if (i.ToString().Contains(usernameInput.text))
            {
                isExists = true;
                break;
            }
        }

        if (isExists)
        {
            // Debug.Log($"Username '{usernameInput.text}' already exists");
            SceneManager.LoadScene("AlreadyExists");
        }
        else
        {
            credentials.Add(usernameInput.text + ":" + passwordInput.text);
            File.WriteAllLines(Application.persistentDataPath + "/credentials.txt", (String[])credentials.ToArray(typeof(string)));
            // Debug.Log("Account Registered");
            SceneManager.LoadScene("RegSuccess");
        }
    }
}
