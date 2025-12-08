using UnityEngine;
using UnityEngine.UI;

public class AllButtonsClick : MonoBehaviour
{
    public AudioSource audioSource; 
    public AudioClip buttonSound;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Retrieve all th buttons in the scene
        Button[] mybuttons = FindObjectsOfType<Button>(true);

        foreach(Button buttonToPlay in mybuttons)
        {
            buttonToPlay.onClick.AddListener(ButtonPressed);
        }
    }

    public void ButtonPressed()
    {
        audioSource.clip = buttonSound;
        audioSource.Play();
    }
}
