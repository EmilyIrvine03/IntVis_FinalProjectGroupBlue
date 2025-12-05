using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CloseInfoPanel : MonoBehaviour
{
    public GameObject Panel;

    public void ClosePanel()
    {
        Panel.SetActive(false);
    }
}

