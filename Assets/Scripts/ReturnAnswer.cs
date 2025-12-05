using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ReturnAnswer : MonoBehaviour, IDropHandler
{
    public AudioSource audioSource; 
    public AudioClip incorrectSound;

    public void OnDrop(PointerEventData eventData)
    {
        GameObject draggedObject = eventData.pointerDrag;
        Debug.Log("Item Dropped on Slot " + draggedObject.name);
        
        RectTransform draggedRectTransform = draggedObject.GetComponent<RectTransform>();
        RectTransform slotRectTransform = GetComponent<RectTransform>();
        float distance = Vector2.Distance(draggedRectTransform.anchoredPosition, slotRectTransform.anchoredPosition);

        if(draggedObject != null && draggedObject.GetComponent<RectTransform>().tag == "Answers")
        {
            draggedRectTransform.anchoredPosition = draggedRectTransform.GetComponent<DragDrop>().initPos;
            Debug.Log("Bad Response. Returned to initial position.");

            audioSource.PlayOneShot(incorrectSound, 0.7f);
        }
    }
}
