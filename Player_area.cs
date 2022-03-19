using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_area : MonoBehaviour
{
    public GameObject recognizedNpc;
    public GameObject recognizedQuest;
    public GameObject recognizedTrigger;

    private void OnTriggerEnter(Collider other) {
        if (other.tag.Equals("NPC")) {
            recognizedNpc = other.gameObject;
            Debug.Log(recognizedNpc.name + "가 주변에 들어옴");
        }

        else if (other.tag.Equals("Quest")) {
            recognizedQuest = other.gameObject;
            Debug.Log(recognizedQuest.name + "가 주변에 들어옴");
        }
        else if (other.tag.Equals("Trigger")) {
            recognizedTrigger = other.gameObject;
            Debug.Log(recognizedTrigger.name + "가 주변에 들어옴");
        }


    }

    private void OnTriggerExit(Collider other) {
        if (other.gameObject == recognizedNpc) {
            recognizedNpc = null;
            Debug.Log(other.name + "가 주변에서 나감");
        }

        else if (other.tag.Equals("Quest")) {
            recognizedQuest = null;
            Debug.Log(other.name + "가 주변에서 나감");
        }
        else if (other.tag.Equals("Trigger")) {
            recognizedTrigger = null;
            Debug.Log(other.name + "가 주변에서 나감");
        }
    }

    public GameObject getRecognizedNPC() {
        return recognizedNpc;
    }

    public GameObject getRecognizedQuest() {
        return recognizedQuest;
    }

    public GameObject getRecognizedTrigger() {
        return recognizedTrigger;
    }
}
