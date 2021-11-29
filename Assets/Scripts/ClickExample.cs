using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.Input;

public class ClickExample : MonoBehaviour, IMixedRealityPointerHandler, IMixedRealityFocusHandler
{
  public void OnFocusEnter(FocusEventData eventData)
  {
    Debug.Log("FocusEnter");
  }

  public void OnFocusExit(FocusEventData eventData)
  {
    Debug.Log("FocusExit");
  }

  public void OnPointerClicked(MixedRealityPointerEventData eventData)
  {
    Debug.Log("Click");
    Destroy(this.gameObject);
  }

  public void OnPointerDown(MixedRealityPointerEventData eventData)
  {
    Debug.Log("PointerDown");
  }

  public void OnPointerDragged(MixedRealityPointerEventData eventData)
  {
    Debug.Log("PointerDragged");
  }

  public void OnPointerUp(MixedRealityPointerEventData eventData)
  {
    Debug.Log("PointerUp");
  }
}
