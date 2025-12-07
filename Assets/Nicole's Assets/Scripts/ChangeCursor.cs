using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ChangeCursor : MonoBehaviour
{
    public Texture2D cursorNormal;
    public Vector2 normalCursorHotSpot;
    
    public Texture2D cursorHand;
    public Vector2 onButtonCursorHotSpot;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnButtonCursorEnter()
    {
        Cursor.SetCursor(cursorHand, onButtonCursorHotSpot, CursorMode.Auto);
    }

    public void OnButtonCursorExit()
    {
        Cursor.SetCursor(cursorNormal, normalCursorHotSpot, CursorMode.Auto);
    }
}
