using UnityEngine;
using TMPro;

public class ManagePlayerPrefs : MonoBehaviour
{

    public void OnClickSave(TextMeshProUGUI myTMProTest)
    {
        PlayerPrefs.SetString("UserName", myTMProTest.text);
    }

    public void OnClickGet()
    {
        string username = PlayerPrefs.GetString("UserName");
        Debug.Log("Welcome back to the app " + username);
    }

    void OnApplicationQuit()
    {
        Debug.Log("Saving PlayerPrefs...");
        PlayerPrefs.Save();
    }
}
