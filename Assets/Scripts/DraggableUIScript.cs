using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DraggableUIScript : MonoBehaviour, IDragHandler
{
    [SerializeField] private RectTransform dragRectTransform;

    public void OnDrag(PointerEventData eventData)
    {
        dragRectTransform.anchoredPosition += eventData.delta;
    }
}