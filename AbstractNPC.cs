using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractNPC: MonoBehaviour
{
    public static string NPC_name;
    public static string[] BEFORE_DIALOG;   // ���� ��ȭ
    public static string[] AFTER_DIALOG;    // �̼� Ŭ���� �� ��ȭ

    public string[] getBeforeDialog() {     // NPC�� ��ȭ �ؽ�Ʈ�� �÷��̾�� ��ȯ
        // Debug.Log(BEFORE_DIALOG);
        return BEFORE_DIALOG;
    }
}
