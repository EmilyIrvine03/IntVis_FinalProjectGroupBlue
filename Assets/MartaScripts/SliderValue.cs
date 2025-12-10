using UnityEngine;
using UnityEngine.UI;

public class SliderScore : MonoBehaviour
{
    public Slider slider;
    public int buttonClickCount = 0;       

   
    public void buttonClickClickCount()
    {
        buttonClickCount++;
        UpdateSlider();
    }

    public void UpdateSlider()
    {
        slider.value = buttonClickCount;
    }

}