using UnityEngine;

public class Color_Change : MonoBehaviour
{
    public GameObject myUterus;
    Color colorStart = Color.red;
    Color colorEnd = Color.white;
    float duration = 0.6f;
    Renderer rend;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rend = myUterus.GetComponent<Renderer>();
    }

    // Update is called once per frame
    /*void OnMouseEnter()
    {
        
            float lerp = Mathf.PingPong(Time.time, duration);
       rend.material.color = Color.Lerp(colorStart, colorEnd, lerp);
        
      
    }*/
     
    public void Update()
    {
        FunctionToCall();
    }

    public void FunctionToCall()
    {
         float lerp = Mathf.PingPong(Time.time, duration);
       rend.material.color = Color.Lerp(colorStart, colorEnd, lerp);
    }
}
