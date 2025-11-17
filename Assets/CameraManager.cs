using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CameraManager : MonoBehaviour
{
    [SerializeField]
   private float speed;

    private Transform target;
    private Transform player;



    void Awake()
    {
        target = GameObject.FindGameObjectWithTag("Uterus").transform;
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void FixedUpdate()
    {
        MoveCam();
    }

    public void MoveCam()
    {
        Vector3 newPos = new Vector3(2.0f, 1.0f, -13);
        transform.position = Vector3.MoveTowards(transform.position, newPos, speed * Time.deltaTime);
    }
}
