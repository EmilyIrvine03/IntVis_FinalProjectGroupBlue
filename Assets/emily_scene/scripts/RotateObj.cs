using UnityEngine;

public class RotateObj : MonoBehaviour
{
    public float rotationSpeed;
    public float rotationDuration;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Debug.Log("Right");
            transform.Rotate(0.0f, -0.1f, 0.0f, Space.Self);
        }

        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            Debug.Log("left");
            transform.Rotate(0.0f, 0.1f, 0.0f, Space.Self);
        }
    }
}
