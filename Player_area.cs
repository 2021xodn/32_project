using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_area : MonoBehaviour
{
    public GameObject recognized_npc;

    private void OnTriggerEnter(Collider other) {
        if (other.tag.Equals("NPC")) {
            recognized_npc = other.gameObject;
            //Debug.Log("NPC들어옴");
            Debug.Log(recognized_npc.name + "가 주변에 들어옴");
        }
        
    }

    private void OnTriggerExit(Collider other) {
        if (other.gameObject == recognized_npc) {
            recognized_npc = null;
            Debug.Log(other.name + "가 주변에서 나감");
        }
    }

    public GameObject getRecognizedNPC() {
        return recognized_npc;
    }
}
