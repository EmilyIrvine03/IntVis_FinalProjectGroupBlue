using UnityEngine;

public class button_b : MonoBehaviour
{
    public GameObject ButtonObj;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ButtonObj = gameObject.GetComponent<GameObject>();
    }

    void OnMouseDown()
    {
        ButtonObj.SetActive(true);
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
