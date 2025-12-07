using UnityEngine;
using UnityEngine.UI;

public class ScrollViewSystem : MonoBehaviour
{
    [SerializeField] private ScrollRect scrollRect;

    [SerializeField] private ScrollViewButton upButton;
    [SerializeField] private ScrollViewButton downButton;

    [SerializeField] private float scrollSpeed = 0.01f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //ScrollRect = GetComponent<ScrollRect>();
    }

    // Update is called once per frame
    void Update()
    {
        if(upButton.isDown)
        {
            ScrollUp();
        }

        if(downButton.isDown)
        {
            ScrollDown();
        }
    }

    private void ScrollUp()
    {
        if(scrollRect.verticalNormalizedPosition <=1f)
        {
          scrollRect.verticalNormalizedPosition += scrollSpeed;
        }
    }

    private void ScrollDown()
    {
        if(scrollRect.verticalNormalizedPosition >=0f)
        {
          scrollRect.verticalNormalizedPosition -= scrollSpeed;
        }
    }
}