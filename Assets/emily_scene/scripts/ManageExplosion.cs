using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class ObjectClassList
{
    public GameObject obj;
    public Vector3 objDisp;
}

public class ManageExplosion : MonoBehaviour
{
    private List<ObjectClassList> myObjList;
    [SerializeField]
    private Transform myExplPivot;

    [SerializeField]
    private int factor = 5;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myObjList = new List<ObjectClassList>();

        //Populate the list with the child attribute of the object
        for (int i = 0; i < transform.childCount; i++)
        {
            ObjectClassList myClassObj = new ObjectClassList();
            myClassObj.obj = transform.GetChild(i).gameObject;
            myClassObj.objDisp = myExplPivot.position - transform.GetChild(i).position;
            myObjList.Add(myClassObj);
        }
    }

    // Update is called once per frame
    void Update()
    {
       
    }
     public void OnSliderChange(Slider mySlider)
        {
            for (int j = 0; j <myObjList.Count; j++)
            {
                myObjList[j].obj.transform.position = myExplPivot.position + myObjList[j].objDisp + myObjList[j].objDisp * factor * mySlider.value;
            }

        }
}
