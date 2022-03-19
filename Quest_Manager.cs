using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quest_Manager : MonoBehaviour {
    public int[,] questProgres = new int[5, 3];   // {진행, 아이템획득 수, 클리어} * 5 NPC

    // NPC
    public AbstractNPC[] npcList = new AbstractNPC[5]; // NPC 5

    string[] Quest_Item = {
        "Letter",
        "Mountain",
        "Leaf",
        "Mirror",
        "Picture"
    };

    string[] Quest_Name = {
        "편지",
        "끝",
        "나뭇잎",
        "거울",
        "사진"
    };

    public GameObject startQuest(AbstractNPC npc) { // 퀘스트 최초 시작, 오브젝트 생성
        string npcName = npc.name;
        GameObject obj = null;

        for (int i = 0; i < 5; i++) {
            if (npc.name.Contains(Quest_Item[i])) {
                if (questProgres[i, 0] == 0) {
                    npcList[i] = npc;
                    questProgres[i, 0] = 1;
                    obj = Resources.Load<GameObject>("Prefabs/Quest/" + Quest_Item[i]);
                }
                break;
            }
        }

        // Debug.Log("매니저 : " + npcName);
        // Debug.Log(obj);

        GameObject questObj = null;
        if (obj) {
            questObj = Instantiate(obj, npc.questArea.transform.position, obj.transform.rotation);
            questObj.name = questObj.name.Replace("(Clone)", "(" + npcName + ")");
            questObj.transform.SetParent(npc.transform.parent.gameObject.transform);    // 자식 오브젝트로 설정
        }

        return questObj;
    }



    public void proceedQuest(GameObject obj) {  // 퀘스트 진행
        for (int i = 0; i < 5; i++) {
            if (obj.name.Contains(Quest_Item[i])) {
                npcList[i].questClear = true;
                questProgres[i, 1] += 1;

                Debug.Log("Proceed Quest : " + obj.name);
                Debug.Log("npcList[i] :" + npcList[i].name);
                Destroy(obj);
                break;
            }
        }
    }

    public (string, int, string[])[] getQuestDialog(GameObject obj) {
        (string, int, string[])[] tmp = null;

        for (int i = 0; i < 5; i++) {
            if (obj.name.Contains(Quest_Item[i])) {
                tmp = npcList[i].getDialog(true);
                break;
            }
        }

        return tmp;
    }

    public bool haveInputEvent(AbstractNPC npc) {
        bool tmp = false;
        for (int i = 0; i < 5; i++) {
            if (npc.name.Contains(Quest_Item[i])) {
                if (i == 0) {
                    tmp = true;
                }
                break;
            }
        }
        

        return tmp;
    }

    public string getQuestItemName(string name) {
        string str = null;
        for (int i = 0; i < 5; i++) {
            if (name.Equals(Quest_Item[i])){
                str = Quest_Name[i];
            }
        }
        return str;
    }
}
