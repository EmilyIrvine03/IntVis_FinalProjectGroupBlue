using UnityEngine; 
using UnityEngine.EventSystems; 

public class DragDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler, IPointerUpHandler

{ 
    
    private RectTransform rectTransform; 
    private CanvasGroup canvasGroup; 
    private Canvas canvas; 
    public Vector3 initPos; 
    public MouseCameraDragOrbitWithZoom cameraOrbit;

    private void Awake () 
    { 
        rectTransform = GetComponent<RectTransform>(); 
        canvasGroup = GetComponent<CanvasGroup>(); 
        canvas = GetComponentInParent<Canvas>();   //parent canvas 
        initPos = rectTransform.anchoredPosition; 
        cameraOrbit = FindFirstObjectByType<MouseCameraDragOrbitWithZoom>();
    } 

    public void OnPointerDown (PointerEventData eventData)  //detects mouse click on object 
    { 
        Debug.Log("Mouse Down");
        cameraOrbit.enabled = false; 
    }

    public void OnBeginDrag(PointerEventData eventData)   //triggers when dragging starts 
    {
        Debug.Log("Begin drag");
        canvasGroup.alpha = 0.6f;     //makes item slightly transparent 
        canvasGroup.blocksRaycasts = false;     //allows drop zones to detect events 
    } 

    public void OnDrag (PointerEventData eventData)    //update on object position based on mouse movement 
    {
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;  
        /*moves the game object by the same amount as the mouse movement, 
        adjusted for canvas scaling*/
    }    

    public void OnEndDrag(PointerEventData eventData)    
    /*fires when dragging ends, 
    contains info. about the mouse pointer i.e. position*/
    {
        Debug.Log("End Drag");
        canvasGroup.alpha = 1f;   //resets the transparency 
        canvasGroup.blocksRaycasts = true;    ///restores raycast blocking 
    } 

    public void OnPointerUp(PointerEventData eventData)
    {
        cameraOrbit.enabled = true;
    }

} 