using UnityEngine;
using UnityEngine.EventSystems; 

public class ItemSlot : MonoBehaviour, IDropHandler 

{
    public GameObject goodResponseObj; 
    
    public void OnDrop(PointerEventData eventData) 
    { 
        // Get the dragged object 
        GameObject draggedObject = eventData.pointerDrag;
        Debug.Log("Item Dropped on Slot " + draggedObject.name); 
       
        if (draggedObject != null) 
        {
            //if Good Response 
            if (draggedObject == goodResponseObj)
            {
                // Snap the dragged object to this slot 
                RectTransform draggedRectTransform = draggedObject.GetComponent<RectTransform>();
                draggedRectTransform.anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            }

            //if bad response 
            else
            {
                RectTransform draggedRectTransform = draggedObject.GetComponent<RectTransform>();
                draggedRectTransform.anchoredPosition = draggedRectTransform.GetComponent<DragDrop>().initPos;
            } 
        } 
    } 
} 