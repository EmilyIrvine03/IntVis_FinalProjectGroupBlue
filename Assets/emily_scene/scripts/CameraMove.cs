using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public GameObject Targetposition;
    public bool camera_move_enabled;
    public Camera MainCamera;
    public int speed = 2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(camera_move_enabled)
        {
            MainCamera.transform.position = Vector3.Lerp (transform.position, Targetposition.transform.position, speed * Time.deltaTime);
        }
        
    }

    public void OnMouseDown()
    {
        Targetposition.transform.position = new Vector3(106, 68, 15);
        camera_move_enabled = true;
    }
}
