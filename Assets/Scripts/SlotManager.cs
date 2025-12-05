using UnityEngine;
using TMPro; 

public class SlotManager : MonoBehaviour
{
    public int totalPlayCount = 8;         //total no. of labels 
    private int globalSoundPlayCount = 0; //no. of correctly placed labels across all slots

    public GameObject EndPanel;
    public TextMeshProUGUI usernameText;
    
    public void LabelPlacedCorrectly()
    {
        globalSoundPlayCount++;
        Debug.Log("Total correct sounds played: " + globalSoundPlayCount);

        if (globalSoundPlayCount >= totalPlayCount)
        {
            Debug.Log("All Labels Placed");
            OpenPanel();
        }
    }

    public void OpenPanel()
    {
        EndPanel.SetActive(true);
        string username = PlayerPrefs.GetString("UserName", "Player"); //retrieves the players name, or prints player is none assigned
        usernameText.text = "Congratulations " + username + "!"; //prints the name trieved
    }

     public int GetSoundPlayCount()
    {
        return globalSoundPlayCount;
    }
}
