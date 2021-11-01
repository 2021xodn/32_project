using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractNPC: MonoBehaviour
{
    public static string NPC_name;
    public static string[] BEFORE_DIALOG;   // 최초 대화
    public static string[] AFTER_DIALOG;    // 미션 클리어 후 대화

    public string[] getBeforeDialog() {     // NPC의 대화 텍스트를 플레이어에게 반환
        // Debug.Log(BEFORE_DIALOG);
        return BEFORE_DIALOG;
    }
}
