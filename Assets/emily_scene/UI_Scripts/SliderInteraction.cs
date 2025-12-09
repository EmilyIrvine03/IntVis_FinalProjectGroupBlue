using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class SliderInteraction : MonoBehaviour
{
    //This script allowed for the slider interaction numbers that are visible in the inspector to be visible in the game play so players can see how they are affecting the babies heart rate
    [SerializeField] private Slider slider;
    [SerializeField] private TMP_Text textField;
    [SerializeField] private bool showDecimalPoints;
    private bool showDeclinePoints;

    private void Reset()
    {
        slider = GetComponent<Slider>();
        textField = GetComponentInChildren<TMP_Text>();
    }

    public void HanldeSliderValueChange(float value)
    {
        if (showDeclinePoints)
            textField.SetText(value.ToString("F2"));
        else
            textField.SetText(value.ToString("F0"));
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
