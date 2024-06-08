using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Survey : MonoBehaviour
{

    [SerializeField] InputField feedback1;

    string URL = "https://docs.google.com/forms/u/0/d/e/1FAIpQLSdajuUioDCJQ28-g_SzHOuoVPQxVqA0bL8bjRvPsF0dZOUF5A/formResponse";

    
    public void Send()
    {
        StartCoroutine(Post(feedback1.text));
        SceneManager.LoadScene("MsgSent");
    }

    IEnumerator Post(string s1)
    {
        WWWForm form = new WWWForm();
        form.AddField("entry.615524096", s1);




        UnityWebRequest www = UnityWebRequest.Post(URL, form);
        
        yield return www.SendWebRequest();

    }


}