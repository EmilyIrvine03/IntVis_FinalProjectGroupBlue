using UnityEngine;
using UnityEngine.UI;

public class SliderValue2 : MonoBehaviour
{
    public Slider slider2;
    public int button2ClickCount = 0;       

   
    public void buttonManageClickClickCount()
    {
        button2ClickCount++;
        UpdateSlider();
    }

    public void UpdateSlider()
    {
        slider2.value = button2ClickCount;
    }

}