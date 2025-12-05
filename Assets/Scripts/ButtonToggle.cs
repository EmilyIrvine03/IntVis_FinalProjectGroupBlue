using UnityEngine;
using System.Collections.Generic;

public class ButtonToggle : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> buttonsToDeactivate;

    public void ButtonDeactivation()
    {
        foreach (GameObject button in buttonsToDeactivate)
        {
            button.SetActive(!button.activeInHierarchy);
        }
    }
}
