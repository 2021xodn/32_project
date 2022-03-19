using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbstractNPC : MonoBehaviour {
    [HideInInspector]
    public string NPC_NAME;

    protected string[] EMPTY_STRING_ARRAY = new string[] { };

    [HideInInspector]
    public (string, int, string[])[] DIALOG_BEFORE;   // ���� ��ȭ
    [HideInInspector]
    public (string, int, string[])[] DIALOG_QUEST;
    [HideInInspector]
    public (string, int, string[])[] DIALOG_CLEAR;
    [HideInInspector]
    public (string, int, string[])[] DIALOG_AFTER;    // �̼� Ŭ���� �� ��ȭ
    [HideInInspector]
    public (string, int, string[])[] DIALOG_ITEM;     // ������ ȹ�� �� ���


    public (string, int)[] DIALOG_TEST;

    public (string, int, string[])[] test;   // �迭 �׽�Ʈ


    GameObject QuestionMarkObj;
    GameObject ExclamationMarkObj;
    GameObject HeartMarkObj;
    private GameObject mark;

    [HideInInspector]
    public bool hasQuest = false;           // ����Ʈ�� ������ �ִ� NPC�� �Ӹ� ���� ! �����
    [HideInInspector]
    public bool questClear;
    [HideInInspector]
    public bool questProgress;

    [HideInInspector]
    public GameObject questObject;          // ����Ʈ���� ã�� ������Ʈ
    public GameObject questArea;


    public (string, int, string[])[] getDialog(bool item) {     // NPC�� ��ȭ �ؽ�Ʈ�� �÷��̾�� ��ȯ
        // Debug.Log(BEFORE_DIALOG);
        (string, int, string[])[] dialog;

        if (item) {
            dialog = DIALOG_ITEM;
        }

        else {
            if (!questProgress) {
                if (!questClear) {
                    dialog = DIALOG_BEFORE;
                }
                else {
                    dialog = DIALOG_AFTER;
                }
            }
            else {
                if (!questClear) {
                    dialog = DIALOG_QUEST;
                }
                else {
                    dialog = DIALOG_CLEAR;
                }
            }
        }

        return dialog;
    }


    public void setQuestOn(GameObject obj) {
        questObject = obj;
        questProgress = true;
    }

    public void loadMark() {
        QuestionMarkObj = Resources.Load<GameObject>("Prefabs/Question_Mark");          // �� ������ ���� �ʿ�
        ExclamationMarkObj = Resources.Load<GameObject>("Prefabs/Exclamation_Mark");
        HeartMarkObj = Resources.Load<GameObject>("Prefabs/Heart_Mark");
    }

    public void renderMark() {              // �Ӹ� ���� ! ? ����
        Destroy(mark);
        GameObject obj = null;
        if (hasQuest) {
            if (!questProgress && !questClear) {
                obj = ExclamationMarkObj;
            }
            else if (!questClear) {
                obj = QuestionMarkObj;
            }
            else if (!questProgress){
                obj = HeartMarkObj;
            }
        }
        else {
        }
        StartCoroutine(MarkDelay(obj, 2.0f));
    }

    IEnumerator MarkDelay(GameObject obj,float delayTime) { // ��ũ ���� ������
        yield return new WaitForSeconds(1f * delayTime); // 2�� ���
        mark = Instantiate(obj, gameObject.transform.position + new Vector3(0, 3.5f, 0), gameObject.transform.rotation);
        mark.name = mark.name.Replace("(Clone)", "(" + gameObject.name + ")");
        
        Debug.Log("��ũ����" + gameObject.name);
        mark.transform.SetParent(transform.parent.gameObject.transform);    // �ڽ� ������Ʈ�� ����
    }
}
