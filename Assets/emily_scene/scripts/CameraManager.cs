using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CameraManager : MonoBehaviour
{
    [SerializeField]
    private GameObject myGameObj;
    [SerializeField]
   private float speed;

    private Transform target;
    private Transform player;



    void Awake()
    {
        target = GameObject.FindGameObjectWithTag("Selectable").transform;
        //player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void OnMouseDown()
    {
    
              MoveCam();
 
    }

    public void MoveCam()
    {
       if(myGameObj.tag == "MainCamera")
       {
         Vector3 newPos = new Vector3(2.0f, 1.0f, -9f);
        myGameObj.transform.position = Vector3.MoveTowards(target.position, newPos, speed * Time.deltaTime);  
       }
    
    }

   
   
}
