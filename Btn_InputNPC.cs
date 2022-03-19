using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Btn_InputNPC : MonoBehaviour, IPointerUpHandler {
    public bool pointUp = false;
    public void OnPointerUp(PointerEventData eventData) {
        pointUp = true;
    }
}
