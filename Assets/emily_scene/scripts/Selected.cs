using UnityEngine;
using System.Collections;

public class Selected : MonoBehaviour
{
    
    void OnMouseOver()
    {
        myOutlineScript.enabled = true;
        //Debug.Log("Mouse is over GameObject");
    }


    void OnMouseExit()
    {
        myOutlineScript.enabled = false;
        //Debug.Log("Mouse is no longer on GameObject");
    }

   



    private Outline myOutlineScript;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        {
          myOutlineScript = transform.GetComponent<Outline>();
        }
        //void OnMouseOver()
        {
            //myOutlineScript.enabled = true;
            //Debug.Log("Mouse over gameobject");
        }


        //void OnMouseExit()
        {
            //myOutlineScript.enabled = false;
            //Debug.Log("mouse off gameobject");
        }






    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
