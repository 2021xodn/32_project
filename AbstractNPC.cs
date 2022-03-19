using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbstractNPC : MonoBehaviour {
    [HideInInspector]
    public string NPC_NAME;

    protected string[] EMPTY_STRING_ARRAY = new string[] { };

    [HideInInspector]
    public (string, int, string[])[] DIALOG_BEFORE;   // 최초 대화
    [HideInInspector]
    public (string, int, string[])[] DIALOG_QUEST;
    [HideInInspector]
    public (string, int, string[])[] DIALOG_CLEAR;
    [HideInInspector]
    public (string, int, string[])[] DIALOG_AFTER;    // 미션 클리어 후 대화
    [HideInInspector]
    public (string, int, string[])[] DIALOG_ITEM;     // 아이템 획득 시 대사


    public (string, int)[] DIALOG_TEST;

    public (string, int, string[])[] test;   // 배열 테스트


    GameObject QuestionMarkObj;
    GameObject ExclamationMarkObj;
    GameObject HeartMarkObj;
    private GameObject mark;

    [HideInInspector]
    public bool hasQuest = false;           // 퀘스트를 가지고 있는 NPC는 머리 위에 ! 띄워줌
    [HideInInspector]
    public bool questClear;
    [HideInInspector]
    public bool questProgress;

    [HideInInspector]
    public GameObject questObject;          // 퀘스트에서 찾을 오브젝트
    public GameObject questArea;


    public (string, int, string[])[] getDialog(bool item) {     // NPC의 대화 텍스트를 플레이어에게 반환
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
        QuestionMarkObj = Resources.Load<GameObject>("Prefabs/Question_Mark");          // 각 프리팹 수정 필요
        ExclamationMarkObj = Resources.Load<GameObject>("Prefabs/Exclamation_Mark");
        HeartMarkObj = Resources.Load<GameObject>("Prefabs/Heart_Mark");
    }

    public void renderMark() {              // 머리 위에 ! ? 생성
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

    IEnumerator MarkDelay(GameObject obj,float delayTime) { // 마크 생성 딜레이
        yield return new WaitForSeconds(1f * delayTime); // 2초 대기
        mark = Instantiate(obj, gameObject.transform.position + new Vector3(0, 3.5f, 0), gameObject.transform.rotation);
        mark.name = mark.name.Replace("(Clone)", "(" + gameObject.name + ")");
        
        Debug.Log("마크렌더" + gameObject.name);
        mark.transform.SetParent(transform.parent.gameObject.transform);    // 자식 오브젝트로 설정
    }
}
