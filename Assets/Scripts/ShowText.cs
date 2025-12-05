using UnityEngine;
using UnityEngine.EventSystems;

public class ShowText : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject Text;

    public void OnPointerEnter(PointerEventData eventData)
    {
        Text.SetActive(true);

    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Text.SetActive(false);
        
    }
}
