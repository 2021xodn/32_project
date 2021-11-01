using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_area : MonoBehaviour
{
    public GameObject recognized_npc;

    private void OnTriggerEnter(Collider other) {
        if (other.tag.Equals("NPC")) {
            recognized_npc = other.gameObject;
            //Debug.Log("NPC����");
            Debug.Log(recognized_npc.name + "�� �ֺ��� ����");
        }
        
    }

    private void OnTriggerExit(Collider other) {
        if (other.gameObject == recognized_npc) {
            recognized_npc = null;
            Debug.Log(other.name + "�� �ֺ����� ����");
        }
    }

    public GameObject getRecognizedNPC() {
        return recognized_npc;
    }
}
