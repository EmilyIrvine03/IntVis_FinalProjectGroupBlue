using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class OpenInfoPanel : MonoBehaviour
{
    public GameObject Panel;

    public void OpenPanel()
    {
        Panel.SetActive(true);
    }
}
