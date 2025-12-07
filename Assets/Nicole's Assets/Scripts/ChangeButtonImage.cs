using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class ChangeButtonImage : MonoBehaviour
{
    private Sprite soundOn;
    public Sprite soundOff;
    public Button button;
    private bool isOn = true;

    public AudioSource audioSource; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        soundOn = button.image.sprite;
    }

   public void ButtonClicked()
    {
        if(isOn)
        {
            button.image.sprite = soundOff;
            isOn = false;

            audioSource.mute = true;
        }

        else
        {
            button.image.sprite = soundOn;
            isOn = true;

            audioSource.mute = false;
        }
    }
}
