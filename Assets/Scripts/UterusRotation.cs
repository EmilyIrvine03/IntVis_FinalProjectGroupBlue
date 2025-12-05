using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class UterusRotation : MonoBehaviour
{
    public GameObject objectToRotate;
    public Slider sliderY;
    private float previousValueY;

    // Start is called before the first frame update
    void Start()
    {
        //Sets an alert for when slider changes
        sliderY.onValueChanged.AddListener(OnSliderChangedY);

        //Set current position of slider
        previousValueY = sliderY.value;
    }

    void OnSliderChangedY (float value)
    {
        float delta = value - previousValueY;
        objectToRotate.transform.Rotate(Vector3.up * delta * 90f);
        previousValueY = value;
    }
}


    

    
