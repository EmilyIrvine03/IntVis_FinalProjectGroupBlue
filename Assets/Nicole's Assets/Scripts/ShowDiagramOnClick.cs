using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ShowDiagramOnClick : MonoBehaviour
{
    public GameObject diagram;
    public bool isShown = false;

    

    public void ShowDiagram()
    {
        if(isShown == false)
        {
            diagram.SetActive(true);
            isShown = true;
            Debug.Log("diagram shown");
        }
        
        else
        {
            diagram.SetActive(false);
            isShown = false;
        }
    }
}