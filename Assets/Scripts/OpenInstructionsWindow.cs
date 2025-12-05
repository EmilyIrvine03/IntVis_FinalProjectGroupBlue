using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class OpenInstructionsWindow : MonoBehaviour
{
    public GameObject Panel;

    public void OpenPanel()
    {
        Panel.SetActive(true);
    }
}