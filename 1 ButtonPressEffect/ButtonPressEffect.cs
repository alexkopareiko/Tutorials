using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonPressEffect : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public void OnPointerDown(PointerEventData eventData)
    {
        gameObject.ButtonDown();
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        gameObject.ButtonUp();
    }
}
