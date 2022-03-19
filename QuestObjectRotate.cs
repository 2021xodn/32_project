using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestObjectRotate : MonoBehaviour
{
    float rotSpeed = 100f;

    void Update() {
        transform.Rotate(new Vector3(0, rotSpeed * Time.deltaTime, 0));
    }
}
