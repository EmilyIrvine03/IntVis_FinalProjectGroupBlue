using UnityEngine;
using System.Collections;
using TMPro;

public class ManageDataViaPlayerPrefs : MonoBehaviour
{
   
    public GameObject inputObj;

    
    public GameObject outputObj;

    public TextMeshProUGUI myText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if(PlayerPrefs.HasKey("username"))
        {
            outputObj.SetActive(true);
            inputObj.SetActive(false);

            Debug.Log("Welcome " + PlayerPrefs.GetString("username"));
        }
        else
        {
            outputObj.SetActive(false);
            inputObj.SetActive(true);
        }
    }

  public void SetUserName()
  {
    PlayerPrefs.SetString("username", myText.text);
    PlayerPrefs.Save();
  }

  public void OnResetClick()
  {
    PlayerPrefs.DeleteKey("username");
  }


}
