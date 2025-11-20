using UnityEngine;

public class MoveToObject : MonoBehaviour

{
    public GameObject mainCamera;
    public GameObject target;
    public float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mainCamera.transform.position = Vector3.MoveTowards(mainCamera.transform.position, target.transform.position, speed * Time.deltaTime);
    }
}
