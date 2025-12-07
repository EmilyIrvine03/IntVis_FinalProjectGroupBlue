using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System.Collections.Generic;

public class ItemSlot1 : MonoBehaviour, IDropHandler 

{
    public GameObject goodResponseObj;
    public List<GameObject> wrongResponseObj;
    public float snapDistance = 80f; //how close label needs to be to snap
    public FlashGreen flashGreen;

    public AudioSource audioSource; 
    public AudioClip correctSound;
    public AudioClip incorrectSound;
    public SlotManager slotManager;
    
    public void OnDrop(PointerEventData eventData) 
    {
        // Get the dragged object 
        GameObject draggedObject = eventData.pointerDrag;
        Debug.Log("Item Dropped on Slot " + draggedObject.name);

        if (draggedObject != null)
        {
            /*get positions of slot and label, allow label to be dropped if near slot
        (as opposed to at an exact position)*/
            RectTransform draggedRectTransform = draggedObject.GetComponent<RectTransform>();
            RectTransform slotRectTransform = GetComponent<RectTransform>();
            float distance = Vector2.Distance(draggedRectTransform.anchoredPosition, slotRectTransform.anchoredPosition);
                        
            //if Good Response 
            if (draggedObject == goodResponseObj && distance <= snapDistance)
            {
                // Snap the dragged object to this slot 
                draggedRectTransform.anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
                Debug.Log("Good Response! Snapped to slot.");

                Image labelToFlash = draggedObject.GetComponent<Image>();
                StartCoroutine(flashGreen.FlashColor(labelToFlash, Color.green));

                audioSource.PlayOneShot(correctSound, 0.7f);
                slotManager.LabelPlacedCorrectly();
            }

            //if bad response 
            else
            {
                draggedRectTransform.anchoredPosition = draggedRectTransform.GetComponent<DragDrop>().initPos;
                Debug.Log("Bad Response. Returned to initial position.");

                    audioSource.PlayOneShot(incorrectSound, 0.7f);
            } 
        } 
    } 
} 